using Domain.Entities.Common;

namespace Domain.Entities
{
    public class PotentialCustomer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string InterestedProduct { get; set; }
        public LeadStatus LeadStatus { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Deal> Deals { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
