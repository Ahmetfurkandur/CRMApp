using MediatR;

namespace Application.Features.Contact.Queries.GetAllContactsQueries
{
    public record GetAllContactsQueryRequest(int Page = 0, int Size = 25) : IRequest<GetAllContactsQueryResponse>;
    
}
