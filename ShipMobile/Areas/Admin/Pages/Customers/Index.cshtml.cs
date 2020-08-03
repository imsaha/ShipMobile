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
    public class IndexModel : PageModel
    {
        private readonly IRepository<Customer> customerRepository;

        public IndexModel(IUnitOfWork unitOfWork)
        {
            customerRepository = unitOfWork.GetRepository<Customer>();
        }


        public List<CustomerDto> Customers { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                var customerQuery = customerRepository.OpenQuery()
                    .Include(x=>x.Mobile)
                    .Include(x=>x.Email)
                    .Select(s => new CustomerDto()
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email==null? null: s.Email.ToString(),
                        Mobile = s.Mobile == null ? null : s.Mobile.ToString(),
                        EmailConfirmed = s.Email != null && s.Email.Confirmed,
                        MobileConfirmed = s.Mobile != null && s.Mobile.Confirmed,
                    });

                Customers = await customerQuery.ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = $"Error - {ex.Message}";
            }

        }
    }
}
