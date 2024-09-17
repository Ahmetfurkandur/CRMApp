using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? WebsiteUrl { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string? ZipCode { get; set; }
        public string Country { get; set; }
        public Guid? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid? PotentialCustomerId { get; set; }
        public PotentialCustomer PotentialCustomer { get; set; }
    }
}
