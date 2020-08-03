using ShipMobile.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Dtos
{
    public class PackageDto
    {
        public long Id { get; set; }

        public bool? Delivered { get; set; }
        public string Note { get; set; }

        public long? AssociateId { get; set; }
        public string AssociateName { get; set; }

        public string Barcode { get; set; }
        public double? WeightInKg { get; set; }
        public PackageType PackageType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Mobile { get; set; }
        public string ContactName { get; set; }
    }
}
