using MediatR;

namespace Application.Features.Deals.Queries;

public record GetAllDealsQueryRequest(int Page = 0, int PageSize = 25): IRequest<GetAllDealsQueryResponse>;