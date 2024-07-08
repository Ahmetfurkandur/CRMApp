using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetAllCustomersQueries
{
    public record GetAllCustomersQueryRequest(int Page = 0, int Size = 25) : IRequest<GetAllCustomersQueryResponse>;
}
