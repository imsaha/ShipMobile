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

namespace ShipMobile.Areas.Admin.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Customer> customerRepository;

        public CreateModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            customerRepository = unitOfWork.GetRepository<Customer>();
        }



        [BindProperty(SupportsGet =true)]
        public long Id { get; set; }


        [BindProperty]
        public CreateCustomerDto CreateCustomer { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                if (Id > 0)
                {
                   var query =  customerRepository
                        .OpenQuery()
                        .Include(m => m.Mobile)
                        .Include(m => m.Email)
                        .Include(x => x.Addresses).ThenInclude(a => a.Address).ThenInclude(m => m.Mobile)
                        .Where(x => x.Id == Id);

                    var projection = query.Select(s => new CreateCustomerDto()
                    {
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email == null ? null : s.Email.ToString(),
                        Mobile = s.Mobile == null ? null : s.Mobile.ToString(),
                        //EmailConfirmed = s.Email != null && s.Email.Confirmed,
                        //MobileConfirmed = s.Mobile != null && s.Mobile.Confirmed,
                    });

                    CreateCustomer = await projection.FirstOrDefaultAsync();
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
                Customer customer;
                if (Id > 0)
                {
                    customer = await customerRepository
                        .OpenQuery()
                        .Include(m=>m.Mobile)
                        .Include(m=>m.Email)
                        .Include(x=>x.Addresses).ThenInclude(a=>a.Address).ThenInclude(m=>m.Mobile)
                        .FirstOrDefaultAsync(x => x.Id == Id);


                    customer.UpdatedById = User.GetUserId();
                    customer.UpdatedAt = DateTimeOffset.Now;
                    customerRepository.Update(customer);
                }
                else
                {
                    customer = new Customer();

                    customer.CreatedById = User.GetUserId();
                    customer.CreatedAt = DateTimeOffset.Now;
                    customerRepository.Add(customer);
                }


                customer.FirstName = CreateCustomer.FirstName;
                customer.LastName = CreateCustomer.LastName;

                customer.Mobile = customer.Mobile ?? new Contact();
                customer.Mobile.Value = CreateCustomer.Mobile;

                customer.Email = customer.Email ?? new Contact();
                customer.Email.Value = CreateCustomer.Email;

               var result = await unitOfWork.CompleteAsync();

                if (result > 0)
                {
                    StatusMessage = "Customer successfully saved.";
                    return RedirectToPage("Index");
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

            return Page();
        }
    }
}
