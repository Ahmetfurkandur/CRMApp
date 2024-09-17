using Application.Common.Interfaces.Repositories.Customer;
using AutoMapper;

namespace Application.Features.Customer.Commands.AddCustomerCommands
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommandRequest, AddCustomerCommandResponse>
    {
        private readonly ICustomerWriteRepository _repository;
        private readonly IMapper _mapper;

        public AddCustomerCommandHandler(ICustomerWriteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AddCustomerCommandResponse> Handle(AddCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Domain.Entities.Customer>(request);
            await _repository.AddAsync(customer);
            await _repository.SaveAsync(cancellationToken);
            return new();
        }
    }
}
