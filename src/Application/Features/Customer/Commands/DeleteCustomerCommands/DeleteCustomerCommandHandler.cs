using Application.Common.Interfaces.Repositories.Customer;

namespace Application.Features.Customer.Commands.DeleteCustomerCommands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        readonly ICustomerWriteRepository _repository;

        public DeleteCustomerCommandHandler(ICustomerWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
            await _repository.SaveAsync(cancellationToken);
            return new();
        }
    }
}
