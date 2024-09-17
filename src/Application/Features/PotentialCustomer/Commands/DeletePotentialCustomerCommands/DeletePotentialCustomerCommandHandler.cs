using Application.Common.Interfaces.Repositories.PotentialCustomer;
using MediatR;

namespace Application.Features.PotentialCustomer.Commands.DeletePotentialCustomerCommands;

public class DeletePotentialCustomerCommandHandler : IRequestHandler<DeletePotentialCustomerCommandRequest, DeletePotentialCustomerCommandResponse>
{

    private readonly IPotentialCustomerWriteRepository writeRepository;

    public DeletePotentialCustomerCommandHandler(IPotentialCustomerWriteRepository writeRepository)
    {
        this.writeRepository = writeRepository;
    }

    public async Task<DeletePotentialCustomerCommandResponse> Handle(DeletePotentialCustomerCommandRequest request, CancellationToken cancellationToken)
    {
        await writeRepository.RemoveAsync(request.Id);
        await writeRepository.SaveAsync(cancellationToken);
        return new();
    }
}