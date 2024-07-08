using Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetAllCustomersQueries
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQueryRequest, GetAllCustomersQueryResponse>
    {
        readonly ICustomerReadRepository _repository;

        public GetAllCustomersQueryHandler(ICustomerReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllCustomersQueryResponse> Handle(GetAllCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            var count = _repository.GetAll(false).Count();
            var data = await _repository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .Select(c => new
                {
                    c.FirstName,
                    c.LastName,
                    c.Role,
                    c.Company,
                    c.CreatedDate,
                    c.UpdatedDate
                }).ToListAsync(cancellationToken);

            return new(data, count);
                
        }
    }
}
