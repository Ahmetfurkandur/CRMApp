using MediatR;

namespace Application.Features.Customer.Queries.GetAllCustomersQueries
{
    public record GetAllCustomersQueryRequest(int Page = 0, int Size = 25) : IRequest<GetAllCustomersQueryResponse>;
}
