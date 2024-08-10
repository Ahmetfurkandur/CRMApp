using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
        readonly IMapper _mapper;

        public GetCustomerDetailQueryHandler(ICustomerReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCustomerDetailQueryResponse> Handle(GetCustomerDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var customer = _repository.GetAll().Include(customers => customers.Contacts).SingleOrDefault(customer => customer.Id == request.Id);
            var response = _mapper.Map<GetCustomerDetailQueryResponse>(customer);
            return response;
        }
    }
}
