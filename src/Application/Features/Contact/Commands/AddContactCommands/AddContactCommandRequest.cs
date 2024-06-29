using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Commands.AddContactCommands
{
    public record AddContactCommandRequest : IRequest<AddContactCommandResponse>
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public string WebsiteUrl { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string ZipCode { get; init; }
        public string Country { get; init; }
        public Guid? CustomerId { get; init; }
        public Guid? PotentialCustomerId { get; init; }

    }
}
