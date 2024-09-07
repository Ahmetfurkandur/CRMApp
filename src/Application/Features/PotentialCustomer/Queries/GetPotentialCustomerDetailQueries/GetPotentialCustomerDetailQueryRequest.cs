using MediatR;

namespace Application.Features.PotentialCustomer.Queries.GetPotentialCustomerDetailQueries
{
    public record GetPotentialCustomerDetailQueryRequest : IRequest<GetPotentialCustomerDetailQueryResponse>
    {
        public Guid Id { get; init; }
    }
}
