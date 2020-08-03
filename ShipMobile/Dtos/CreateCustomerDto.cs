using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Dtos
{
    public class CreateCustomerDto
    {
        [Display(Name ="First name"), Required, MinLength(5), MaxLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last name"), Required, MaxLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Mobile number"), Phone, Required]
        public string Mobile { get; set; }

        [Display(Name = "Email"), EmailAddress]
        public string Email { get; set; }
    }
}
