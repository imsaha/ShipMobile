using ShipMobile.Data.ValueObjects;

namespace ShipMobile.Data.Models
{
    public class ShippingAddress : BaseEntity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public GeoCoordinate GeoCoordinate { get; set; }

        public string ContactName { get; set; }
        public string Mobile { get; set; }
    }
}
