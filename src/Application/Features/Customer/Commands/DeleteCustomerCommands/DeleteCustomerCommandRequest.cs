using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.DeleteCustomerCommands
{
    public record DeleteCustomerCommandRequest(Guid Id) : IRequest<DeleteCustomerCommandResponse>;
    
}
