using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using ShipMobile.Data.Models;
using ShipMobile.Dtos;
using ShipMobile.Repositories.Interfaces;

namespace ShipMobile.Areas.Admin.Pages.Associates
{
    public class CreateModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository<ApplicationUser> userRepository;

        public CreateModel(
            IUnitOfWork unitOfWork, 
            UserManager<ApplicationUser> userManager
            )
        {
            this.userManager = userManager;
            userRepository = unitOfWork.GetRepository<ApplicationUser>();

        }


        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }


        [BindProperty]
        public CreateAssociateDto CreateAssociate { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                if (Id > 0)
                {
                    var query = userRepository
                         .OpenQuery()
                         .Where(x => x.Id == Id);

                    var projection = query.Select(s => new CreateAssociateDto()
                    {
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email,
                        Mobile = s.PhoneNumber,
                        //EmailConfirmed = s.Email != null && s.Email.Confirmed,
                        //MobileConfirmed = s.Mobile != null && s.Mobile.Confirmed,
                    });

                    CreateAssociate = await projection.FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            try
            {
                ApplicationUser associate;
                if (Id > 0)
                {
                    associate = await userManager.FindByIdAsync(Id.ToString());
                    associate.FirstName = CreateAssociate.FirstName;
                    associate.LastName = CreateAssociate.LastName;
                    associate.PhoneNumber = CreateAssociate.Mobile;
                    associate.RoleName = "DeliveryAssociate";
                    associate.EmailConfirmed = true;
                    associate.PhoneNumberConfirmed = true;

                    await userManager.UpdateAsync(associate);
                }
                else
                {
                    associate = new ApplicationUser()
                    {
                        FirstName= CreateAssociate.FirstName,
                        LastName= CreateAssociate.LastName,
                        Email= CreateAssociate.Email,
                        UserName= CreateAssociate.Email,
                        PhoneNumber= CreateAssociate.Mobile,
                        RoleName = "DeliveryAssociate",
                        EmailConfirmed=true,
                        PhoneNumberConfirmed=true
                    };


                    var result =await userManager.CreateAsync(associate, CreateAssociate.Password);
                    if (!result.Succeeded)
                        throw new InvalidOperationException();
                }

                var isInRole = await userManager.IsInRoleAsync(associate, "DeliveryAssociate");
                if (!isInRole)
                    await userManager.AddToRoleAsync(associate, "DeliveryAssociate");

                StatusMessage = "Customer successfully saved.";
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

            return Page();
        }
    }
}
