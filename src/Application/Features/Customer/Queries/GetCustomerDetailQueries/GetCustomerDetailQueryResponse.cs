using Application.Common.Dtos;

namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public record GetCustomerDetailQueryResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public List<ContactDto> Contacts { get; init; }
    }
}