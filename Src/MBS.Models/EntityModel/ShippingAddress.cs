using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel
{
    public class ShippingAddress
    {
        public long Id { get; set; }
        public string UserId { get; set; } // Link to the user
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsDefault { get; set; } // Default address flag

    }
}
