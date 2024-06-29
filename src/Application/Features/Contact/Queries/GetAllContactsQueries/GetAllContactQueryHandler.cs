using Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Queries.GetAllContactsQueries
{
    public class GetAllContactQueryHandler : IRequestHandler<GetAllContactsQueryRequest, GetAllContactsQueryResponse>
    {
        readonly IContactReadRepository _contactReadRepository;

        public GetAllContactQueryHandler(IContactReadRepository contactReadRepository)
        {
            _contactReadRepository = contactReadRepository;
        }

        public async Task<GetAllContactsQueryResponse> Handle(GetAllContactsQueryRequest request, CancellationToken cancellationToken)
        {
            int count = _contactReadRepository.GetAll(false).Count();
            var data = await _contactReadRepository.GetAll(false).Skip(request.Page * request.Size)
                .Take(request.Size).Select(c => new
                {
                    c.Id,
                    c.ContactName,
                    c.Email,
                    c.PhoneNumber,
                    c.WebsiteUrl,
                    c.Address,
                    c.City,
                    c.ZipCode,
                    c.Country,
                    c.CreatedDate,
                    c.UpdatedDate
                }).ToListAsync(cancellationToken);

            return new GetAllContactsQueryResponse(data, count);
        }
    }
}
