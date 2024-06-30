using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Commands.UpdateContactCommands
{
    public record UpdateContactCommandRequest : IRequest<UpdateContactCommandResponse>
    {
        public Guid Id { get; init; }
        public string ContactName { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public string WebsiteUrl { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string ZipCode { get; init; }
        public string Country { get; init; }
        public Guid CustomerId { get; init; }
        public Guid PotentialCustomerId { get; init; }
    }
}
