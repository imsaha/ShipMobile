using ShipMobile.Data.ValueObjects;
using System.Collections;
using System.Collections.Generic;

namespace ShipMobile.Data.Models
{
    public class Customer:AuditableEntity
    {
        public Customer()
        {
            Addresses = new HashSet<CustomerAddress>();
            Packages = new HashSet<Package>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public long? MobileId { get; set; }
        public Contact Mobile { get; set; }

        public long? EmailId { get; set; }
        public Contact Email { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}".Trim();
        }

        public ICollection<CustomerAddress> Addresses { get; private set; }
        public ICollection<Package> Packages { get; private set; }
    }

    public class CustomerAddress
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public bool IsOffice { get; set; }

    }
}
