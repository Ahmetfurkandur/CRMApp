using MediatR;

namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public record GetCustomerDetailQueryRequest(Guid Id): IRequest<GetCustomerDetailQueryResponse>;
}
