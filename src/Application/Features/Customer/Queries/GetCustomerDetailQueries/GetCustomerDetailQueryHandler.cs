using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQueryRequest, GetCustomerDetailQueryResponse>
    {
        readonly ICustomerReadRepository _repository;

        public GetCustomerDetailQueryHandler(ICustomerReadRepository repository)
        {
            _repository = repository;
        }

        public Task<GetCustomerDetailQueryResponse> Handle(GetCustomerDetailQueryRequest request, CancellationToken cancellationToken)
        {
            //var customer = _repository.GetByIdAsync(request.Id).Include()
        }
    }
}
