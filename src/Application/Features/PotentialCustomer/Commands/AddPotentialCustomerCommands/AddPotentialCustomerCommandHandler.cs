using Application.Common.Interfaces.Repositories.PotentialCustomer;
using AutoMapper;
using MediatR;

namespace Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands
{
    public class AddPotentialCustomerCommandHandler : IRequestHandler<AddPotentialCustomerCommandRequest, AddPotentialCustomerCommandResponse>
    {
        readonly IMapper _mapper;
        readonly IPotentialCustomerWriteRepository _repository;
        public AddPotentialCustomerCommandHandler(IMapper mapper, IPotentialCustomerWriteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AddPotentialCustomerCommandResponse> Handle(AddPotentialCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var potentialCustomer = _mapper.Map<Domain.Entities.PotentialCustomer>(request);
            await _repository.AddAsync(potentialCustomer);
            await _repository.SaveAsync(cancellationToken);
            return new();
        }
    }
}
