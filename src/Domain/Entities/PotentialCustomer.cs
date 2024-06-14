using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class PotentialCustomer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string Sector { get; set; }
        public string InterestedPoduct { get; set; }
        public DealStatus DealStatus { get; set; }
        public Contact Contact { get; set; }
    }
}
