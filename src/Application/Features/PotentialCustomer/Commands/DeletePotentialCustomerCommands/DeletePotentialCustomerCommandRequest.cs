using MediatR;

namespace Application.Features.PotentialCustomer.Commands.DeletePotentialCustomerCommands
{
    public record DeletePotentialCustomerCommandRequest : IRequest<DeletePotentialCustomerCommandResponse>
    {
        public DeletePotentialCustomerCommandRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

    }
}
