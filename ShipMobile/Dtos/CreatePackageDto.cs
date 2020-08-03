using ShipMobile.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Dtos
{
    public class CreatePackageDto
    {
        [Display(Name = "Weight")]
        public double? WeightInKg { get; set; }

        [Display(Name ="Package type"), Required]
        public PackageType PackageType { get; set; }

        [Display(Name ="Customer"), Required]
        public long CustomerId { get; set; }


        // Currently it has no use. 
        // The plan was to save the customer shipment address 
        // and let user either select or create a new shipment address.
        [Display(Name = "Address")]
        public long? AddressId { get; set; }

        [Required, MaxLength(255)]
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        [Required, MaxLength(255)]
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        [Display(Name = "Zipcode")]
        public string ZipCode { get; set; }

        [Display(Name ="Contact name"), Required]
        public string ContactName { get; set; }

        [Required, MaxLength(9)]
        public string Mobile { get; set; }

    }
}
