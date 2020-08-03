using ShipMobile.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.Models
{
    public class Address:AuditableEntity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public GeoCoordinate GeoCoordinate { get; set; }

        public long MobileId { get; set; }
        public Contact Mobile { get; set; }
    }
}
