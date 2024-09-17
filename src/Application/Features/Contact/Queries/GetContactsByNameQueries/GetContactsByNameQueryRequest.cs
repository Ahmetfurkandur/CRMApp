using MediatR;

namespace Application.Features.Contact.Queries.GetContactsByNameQueries
{
    public record GetContactsByNameQueryRequest(string Name) : IRequest<GetContactsByNameQueryResponse>;
   
}
