using Application.Common.Interfaces.Repositories.Contact;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Contact.Queries.GetContactsByNameQueries
{
    public class GetContactsByNameQueryHandler : IRequestHandler<GetContactsByNameQueryRequest, GetContactsByNameQueryResponse>
    {
        readonly IContactReadRepository _repository;

        public GetContactsByNameQueryHandler(IContactReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetContactsByNameQueryResponse> Handle(GetContactsByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var contacts = await _repository.GetWhere(c => c.ContactName.Contains(request.Name))
                .Select(c => new
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

            return new GetContactsByNameQueryResponse(contacts);
        }
    }
}
