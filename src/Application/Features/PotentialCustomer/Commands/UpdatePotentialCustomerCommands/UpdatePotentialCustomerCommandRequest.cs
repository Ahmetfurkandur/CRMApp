using Domain.Entities.Common;
using MediatR;

namespace Application.Features.PotentialCustomer.Commands.UpdatePotentialCustomerCommands
{
    public record UpdatePotentialCustomerCommandRequest : IRequest<UpdatePotentialCustomerCommandResponse>
    {
        public Guid Id { get; set; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Role { get; init; }
        public string Company { get; init; }
        public string InterestedProduct { get; init; }
        public LeadStatus LeadStatus { get; init; }
    }
}
