using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.UpdateCustomerCommands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        readonly ICustomerReadRepository _readRepository;
        readonly ICustomerWriteRepository _writeRepository;

        public UpdateCustomerCommandHandler(ICustomerReadRepository readRepository, ICustomerWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = await _readRepository.GetByIdAsync(request.Id);
            customer.FirstName = request.FirstName;
            customer.LastName = request.LastName;
            customer.Company = request.Company;
            customer.Role = request.Role;
            await _writeRepository.SaveAsync(cancellationToken);

            return new();
        }
    }
}
