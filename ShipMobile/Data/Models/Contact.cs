using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.Models
{
    public class Contact:BaseEntity
    {
        public string Prefix { get; set; }
        public string Value { get; set; }

        public bool Confirmed { get; set; }

        public override string ToString()
        {
            return $"{Prefix}{Value}";
        }
    }
}
