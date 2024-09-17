using MediatR;

namespace Application.Features.Customer.Commands.DeleteCustomerCommands
{
    public record DeleteCustomerCommandRequest(Guid Id) : IRequest<DeleteCustomerCommandResponse>;
    
}
