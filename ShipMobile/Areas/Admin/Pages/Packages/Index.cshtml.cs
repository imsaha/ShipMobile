using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using ShipMobile.Data.Models;
using ShipMobile.Dtos;
using ShipMobile.Repositories.Interfaces;

namespace ShipMobile.Areas.Admin.Pages.Packages
{
    public class IndexModel : PageModel
    {
        private IRepository<Package> packageRepository;
        private IRepository<ApplicationUser> associateRepository;
        private readonly IUnitOfWork unitOfWork;

        public IndexModel(IUnitOfWork unitOfWork)
        {
            packageRepository = unitOfWork.GetRepository<Package>();
            associateRepository = unitOfWork.GetRepository<ApplicationUser>();
            this.unitOfWork = unitOfWork;
        }


        [BindProperty]
        public AssignPackageToAssociateRequest AssignPackage { get; set; }

        public ICollection<PackageDto> Packages { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
        public async Task OnGetAsync()
        {
            try
            {
                var query = packageRepository.OpenQuery()
                    .Include(a => a.Address)
                    .Include(a => a.Customer).ThenInclude(m => m.Mobile)
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
                        WeightInKg = s.WeightInKg,
                        Delivered = s.Delivered,
                        AssociateName = s.Agent == null ? null : s.Agent.FirstName + " " + s.Agent.LastName,
                        ContactName = s.Address.ContactName,
                        Note = s.Delivered == true ? s.SuccessNote : s.FailedNote,
                        AssociateId = s.AgentId
                    });

                Packages = await query.ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

        }


        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (AssignPackage != null && AssignPackage.PackageId > 0)
                {
                    var package = await packageRepository.OpenQuery().FirstOrDefaultAsync(x => x.Id == AssignPackage.PackageId);
                    if (package == null)
                        throw new InvalidEnumArgumentException("PackageId");

                    if (AssignPackage.Assign)
                    {
                        var agent = await associateRepository.OpenQuery()
                                               .FirstOrDefaultAsync(x => x.RoleName.ToLower() == "deliveryassociate" && x.Id == AssignPackage.AssociateId);
                        if (agent == null)
                            throw new InvalidEnumArgumentException("AssociateId");

                        package.AgentId = agent.Id;
                    }
                    else
                    {
                        package.Agent = null;
                        package.AgentId = null;
                    }

                    packageRepository.Update(package);

                    var result = await unitOfWork.CompleteAsync();
                    if (result > 0)
                        StatusMessage = "Package successfully " + (AssignPackage.Assign ? "assigned." : "removed the assignment.");

                    return RedirectToPage();
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

            return Page();
        }


        public async Task<List<SelectListItem>> GetAssociatesAsync()
        {
            var userQuery = associateRepository.OpenQuery()
                   .Where(x => x.RoleName.ToLower() == "deliveryassociate")
                   .Select(s => new SelectListItem(s.FirstName + " " + s.LastName, s.Id.ToString()));
            return await userQuery.ToListAsync();
        }


    }

    public class AssignPackageToAssociateRequest
    {
        public long PackageId { get; set; }
        public long AssociateId { get; set; }
        public bool Assign { get; set; }
    }
}
