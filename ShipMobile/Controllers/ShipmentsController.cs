using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShipMobile.Data.Models;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Controllers
{
    [Authorize]
    public class ShipmentsController : BaseAPIController
    {
        private readonly IRepository<ApplicationUser> userRepository;
        public ShipmentsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            userRepository = unitOfWork.GetRepository<ApplicationUser>();
        }

        [HttpGet, Route("test")]
        public IActionResult Test()
        {
            var user = userRepository
                .OpenQuery()
                .FirstOrDefault(x => x.Email == "sirajmsaha@gmail.com");

            return Ok(user);
        }

    }
}
