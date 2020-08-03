using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Dtos
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Mobile { get; set; }
        public bool MobileConfirmed { get; set; }
        public int SuccessDeliveredCount { get; set; }
        public int FailedDeliveredCount { get; set; }
    }
}
