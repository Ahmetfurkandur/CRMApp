using Domain.Entities.Common;

namespace Application.Common.Dtos
{
    public class PotentialCustomerDetailDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string InterestedProduct { get; set; }
        public LeadStatus LeadStatus { get; set; }
        public List<ContactDto> Contacts { get; set; }
        //public ICollection<Deal> Deals { get; set; }
        //public ICollection<Domain.Entities.Task> Tasks { get; set; }
    }
}
