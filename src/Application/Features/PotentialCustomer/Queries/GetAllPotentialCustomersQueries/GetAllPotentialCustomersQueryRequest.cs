using MediatR;

namespace Application.Features.PotentialCustomer.Queries.GetAllPotentialCustomersQueries
{
    public record GetAllPotentialCustomersQueryRequest(int Page = 0, int Size = 25): IRequest<GetAllPotentialCustomersQueryResponse>;
}
