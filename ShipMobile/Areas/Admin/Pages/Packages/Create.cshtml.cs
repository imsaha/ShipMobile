using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShipMobile.Data.Models;
using ShipMobile.Dtos;
using ShipMobile.Repositories.Interfaces;

namespace ShipMobile.Areas.Admin.Pages.Packages
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Package> packageRepository;
        private readonly IRepository<Customer> customerRepository;

        public CreateModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            packageRepository = unitOfWork.GetRepository<Package>();
            customerRepository = unitOfWork.GetRepository<Customer>();
        }


        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }


        [BindProperty]
        public CreatePackageDto CreatePackage { get; set; }


        [TempData]
        public string StatusMessage { get; set; }
        public async Task OnGetAsync()
        {
            try
            {
                if (Id > 0)
                {
                    var query = packageRepository.OpenQuery()
                        .Include(c=>c.Address)
                        .Where(x => x.Id == Id)
                        .Select(s => new CreatePackageDto()
                        {
                            CustomerId= s.CustomerId,
                            AddressId= s.AddressId,
                            Line1= s.Address.Line1,
                            Line2= s.Address.Line2,
                            City= s.Address.City,
                            State= s.Address.State,
                            Country= s.Address.Country,
                            ZipCode= s.Address.ZipCode,
                            ContactName= s.Address.ContactName,
                            Mobile = s.Address.Mobile,
                            PackageType= s.PackageType,
                            WeightInKg= s.WeightInKg
                        });

                    CreatePackage = await query.FirstOrDefaultAsync();
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
                Package package;
                if (Id > 0)
                {
                    package = await packageRepository.OpenQuery()
                        .Include(a=>a.Address)
                        .FirstOrDefaultAsync(x => x.Id == Id);

                    packageRepository.Update(package);
                }
                else
                {
                    package = new Package();
                    package.Token = $"{DateTime.Now.Ticks:x}";
                    packageRepository.Add(package);
                }

                var customerExist = await customerRepository.OpenQuery().AnyAsync(x => x.Id == CreatePackage.CustomerId);
                if (!customerExist)
                    throw new InvalidEnumArgumentException("Invalid customer");

                package.CustomerId = CreatePackage.CustomerId;
                package.PackageType = CreatePackage.PackageType;
                package.WeightInKg = CreatePackage.WeightInKg;
                package.Address = package.Address ?? new ShippingAddress();
                package.Address.Line1 = CreatePackage.Line1;
                package.Address.Line2= CreatePackage.Line2;
                package.Address.City= CreatePackage.City;
                package.Address.State= CreatePackage.State;
                package.Address.Country= CreatePackage.Country;
                package.Address.ZipCode= CreatePackage.ZipCode;
                package.Address.Mobile= CreatePackage.Mobile;
                package.Address.ContactName= CreatePackage.ContactName;

                var result = await unitOfWork.CompleteAsync();
                if (result <= 0)
                    throw new Exception("Something unexpected occurred.");

                StatusMessage = "Package successfully saved.";
                return RedirectToPage("Create", new { Id = package.Id});
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

            return Page();
        }


        public Task< List<SelectListItem>> GetCustomersAsync()=> 
            customerRepository.OpenQuery()
            .Select(s => new SelectListItem(s.FirstName + " " + s.LastName, s.Id.ToString())).ToListAsync();

        public Task<List<SelectListItem>> GetCustomersAddressAsync(long customerId) => 
            customerRepository.OpenQuery()
            .Where(x=>x.Id== customerId)
            .Include(s=>s.Addresses).ThenInclude(a=>a.Address)
            .SelectMany(a=>a.Addresses)
            .Select(s => new SelectListItem(s.Address.Line1 + " " + s.Address.City, s.AddressId.ToString())).ToListAsync();


    }
}
