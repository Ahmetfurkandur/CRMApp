using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
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
