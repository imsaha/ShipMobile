using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.ValueObjects
{
    public class GeoCoordinate : ValueObject
    {
        public GeoCoordinate()
        {
        }

        public GeoCoordinate(decimal latitude, decimal longitude):this()
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Latitude;
            yield return Longitude;
        }

        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }
    }
}
