using Application.Common.Interfaces.Repositories.PotentialCustomer;
using MediatR;

namespace Application.Features.PotentialCustomer.Commands.UpdatePotentialCustomerCommands
{
    public class UpdatePotentialCustomerCommandHandler : IRequestHandler<UpdatePotentialCustomerCommandRequest, UpdatePotentialCustomerCommandResponse>
    {

        private readonly IPotentialCustomerWriteRepository _writeRepository;
        private readonly IPotentialCustomerReadRepository _readRepository;

        public UpdatePotentialCustomerCommandHandler(IPotentialCustomerWriteRepository writeRepository, IPotentialCustomerReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }


        public async Task<UpdatePotentialCustomerCommandResponse> Handle(UpdatePotentialCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var potentialCustomer = await _readRepository.GetByIdAsync(request.Id);
            potentialCustomer.FirstName = request.FirstName;
            potentialCustomer.LastName = request.LastName;
            potentialCustomer.Role = request.Role;
            potentialCustomer.Company = request.Company;
            potentialCustomer.InterestedProduct = request.InterestedProduct;
            potentialCustomer.LeadStatus = request.LeadStatus;
            await _writeRepository.SaveAsync(cancellationToken);

            return new();
        }
    }
}
