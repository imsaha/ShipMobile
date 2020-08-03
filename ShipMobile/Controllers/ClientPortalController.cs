using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipMobile.Data.Models;
using ShipMobile.Dtos;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Controllers
{
    public class ClientPortalController : BaseAPIController
    {
        private IRepository<Package> packageRepository;

        public ClientPortalController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            packageRepository = unitOfWork.GetRepository<Package>();
        }

        #region Dashboard

        [HttpGet, Route("Dashboard")]
        public async Task<IActionResult> GetPackageDeliveryCount()
        {
            var successCount = await packageRepository.OpenQuery()
               .Where(x => x.AgentId == User.GetUserId() && x.Delivered == true)
               .Distinct().CountAsync();

            var failedCount = await packageRepository.OpenQuery()
               .Where(x => x.AgentId == User.GetUserId() && x.Delivered == false)
               .Distinct().CountAsync();

            var waitingCount = await packageRepository.OpenQuery()
              .Where(x => x.AgentId == User.GetUserId() && x.Delivered == null)
              .Distinct().CountAsync();

            return Ok(new
            {
                success = successCount,
                failed = failedCount,
                waiting = waitingCount
            });
        }


        #endregion


        [HttpGet, Route("Packages/{token}")]
        public async Task<IActionResult> GetPackageByToken(string token)
        {
            var query = packageRepository.OpenQuery()
                .Where(x => x.Token == token && x.AgentId == User.GetUserId())
                .Select(s => new PackageDto()
                {
                    Id = s.Id,
                    Barcode = s.Token,
                    Line1 = s.Address.Line1,
                    Line2 = s.Address.Line2,
                    City = s.Address.City,
                    State = s.Address.State,
                    Country = s.Address.Country,
                    ZipCode = s.Address.ZipCode,
                    Mobile = s.Address.Mobile,
                    ContactName = s.Address.ContactName,
                    PackageType = s.PackageType,
                    WeightInKg = s.WeightInKg
                });

            var result = await query.FirstOrDefaultAsync();
            if (result == null)
                return NotFound();
            return Ok(result);
        }



        [HttpPost, Route("Packages/Delivered")]
        public async Task<IActionResult> DeliveredPackageByToken(PackageDeliveredRequest request)
        {
            if (request == null || request.Tokens == null || request.Tokens.Length == 0)
                return BadRequest();

            foreach (var item in request.Tokens)
            {
                var query = packageRepository.OpenQuery()
                .Where(x => x.Token == item && x.AgentId == User.GetUserId());

                var package = await query.FirstOrDefaultAsync();
                if (package != null)
                {
                    packageRepository.Update(package);
                    package.Delivered = request.IsSuccess;
                    package.SuccessNote = request.IsSuccess ? request.Note : string.Empty;
                    package.FailedNote = !request.IsSuccess ? request.Note : string.Empty;
                }
            }

            var result = await UnitOfWork.CompleteAsync();
            if (result <= 0)
                return BadRequest("Something unexpected happened.");

            return Ok();
        }
    }

    public class PackageDeliveredRequest
    {
        public string[] Tokens { get; set; }
        public bool IsSuccess { get; set; }
        public string Note { get; set; }
    }
}
