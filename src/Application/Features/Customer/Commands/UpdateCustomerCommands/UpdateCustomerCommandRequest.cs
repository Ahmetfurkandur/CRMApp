using MediatR;

namespace Application.Features.Customer.Commands.UpdateCustomerCommands
{
    public record UpdateCustomerCommandRequest : IRequest<UpdateCustomerCommandResponse>
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Company { get; init; }
        public string Role { get; init; }
    }
}
