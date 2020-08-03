using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.Models
{
    public class Package : BaseEntity
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long AddressId { get; set; }
        public ShippingAddress Address { get; set; }


        public long? AgentId { get; set; }
        public ApplicationUser Agent { get; set; }


        public double? WeightInKg { get; set; }

        public PackageType PackageType { get; set; }

        public string Token { get; set; }

        public bool? Delivered { get; set; }
        public string SuccessNote { get; set; }
        public string FailedNote { get; set; }
    }
}
