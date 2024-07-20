using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public record GetCustomerDetailQueryRequest(Guid Id): IRequest<GetCustomerDetailQueryResponse>;
}
