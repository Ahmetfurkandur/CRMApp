using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Queries.GetAllContactsQueries
{
    public record GetAllContactsQueryRequest(int Page = 0, int Size = 25) : IRequest<GetAllContactsQueryResponse>;
    
}
