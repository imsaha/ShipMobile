using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShipMobile.Dtos
{
    public class CreateAssociateDto
    {
        [Display(Name = "First name"), Required, MinLength(5), MaxLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last name"), Required, MaxLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Email"), EmailAddress, Required]
        public string Email { get; set; }

        [Display(Name = "Mobile number"), Phone, Required]
        public string Mobile { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
