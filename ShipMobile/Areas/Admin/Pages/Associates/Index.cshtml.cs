using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShipMobile.Data.Models;
using ShipMobile.Dtos;
using ShipMobile.Repositories.Interfaces;

namespace ShipMobile.Areas.Admin.Pages.Associates
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<ApplicationUser> usersRepository;
        private readonly IRepository<ApplicationRole> rolesRepository;

        public IndexModel(IUnitOfWork unitOfWork)
        {
            usersRepository = unitOfWork.GetRepository<ApplicationUser>();
            rolesRepository = unitOfWork.GetRepository<ApplicationRole>();
        }

        public List<UserDto> Users { get; set; }


        [TempData]
        public string StatusMessage { get; set; }


        public async Task OnGetAsync()
        {
            try
            {
                var userQuery = usersRepository.OpenQuery()
                    .Where(x => x.RoleName.ToLower() == "deliveryassociate")
                    .Select(s => new UserDto()
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email,
                        Mobile = s.PhoneNumber,
                        EmailConfirmed = s.EmailConfirmed,
                        MobileConfirmed = s.PhoneNumberConfirmed,
                        Role = s.RoleName
                    });

                Users = await userQuery.ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

        }
    }
}
