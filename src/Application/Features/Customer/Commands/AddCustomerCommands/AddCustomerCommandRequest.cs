using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.AddCustomerCommands
{
    public record AddCustomerCommandRequest : IRequest<AddCustomerCommandResponse>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Role { get; init; }
        public string Company { get; init; }
    }
}
