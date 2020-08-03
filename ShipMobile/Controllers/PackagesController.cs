using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class PackagesController : BaseAPIController
    {
        private IRepository<Package> packageRepository;

        public PackagesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            packageRepository = unitOfWork.GetRepository<Package>();
        }

        [HttpGet, Route("{token}")]
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
                    PackageType = s.PackageType,
                    WeightInKg = s.WeightInKg
                });

            var result = await query.FirstOrDefaultAsync();
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
