using Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PotentialCustomer.Queries.GetAllPotentialCustomersQueries
{
    public class GetAllPotentialCustomersQueryHandler : IRequestHandler<GetAllPotentialCustomersQueryRequest, GetAllPotentialCustomersQueryResponse>
    {

        readonly IPotentialCustomerReadRepository _repository;

        public GetAllPotentialCustomersQueryHandler(IPotentialCustomerReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllPotentialCustomersQueryResponse> Handle(GetAllPotentialCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            int count = _repository.GetAll(false).Count();
            var data = await _repository.GetAll(false).Skip(request.Page * request.Size)
                .Take(request.Size).Select(p => new
                {
                    p.FirstName,
                    p.LastName,
                    p.Role,
                    p.Company,
                    p.InterestedProduct,
                    p.LeadStatus
                }).ToListAsync(cancellationToken);
            
            return new(data, count);
        }
    }
}
