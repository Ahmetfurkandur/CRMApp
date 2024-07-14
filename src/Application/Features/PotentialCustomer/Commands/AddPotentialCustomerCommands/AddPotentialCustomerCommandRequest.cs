using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands
{
    public record AddPotentialCustomerCommandRequest : IRequest<AddPotentialCustomerCommandResponse>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Role { get; init; }
        public string Company { get; init; }
        public string InterestedProduct { get; init; }
        public LeadStatus LeadStatus { get; init; }
    }
}
