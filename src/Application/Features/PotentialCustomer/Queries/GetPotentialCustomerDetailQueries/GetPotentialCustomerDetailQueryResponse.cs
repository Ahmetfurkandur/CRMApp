using Application.Common.Dtos;
using Domain.Entities.Common;

namespace Application.Features.PotentialCustomer.Queries.GetPotentialCustomerDetailQueries
{
    public record GetPotentialCustomerDetailQueryResponse
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Role { get; init; }
        public string Company { get; init; }
        public string InterestedProduct { get; init; }
        public LeadStatus LeadStatus { get; init; }
        public List<ContactDto> Contacts { get; init; }
    }
}