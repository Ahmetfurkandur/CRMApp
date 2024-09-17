using Application.Common.Interfaces.Repositories;
using Application.Common.Interfaces.Repositories.Deal;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Deals.Queries;

public class GetAllDealsQueryHandler : IRequestHandler<GetAllDealsQueryRequest, GetAllDealsQueryResponse>
{
    private readonly IDealReadRepository _readRepository;

    public GetAllDealsQueryHandler(IDealReadRepository readRepository)
    {
        _readRepository = readRepository;
    }

    public async Task<GetAllDealsQueryResponse> Handle(GetAllDealsQueryRequest request, CancellationToken cancellationToken)
    {
        var count = _readRepository.GetAll(false).Count();
        var data = await _readRepository.GetAll(false)
            .Skip((request.Page - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(d => new
            {
                d.Id,
                d.Name,
                d.Description,
                d.DealStatus,
                d.Amount,
                d.CloseDate,
                d.Tags,
                d.Owner
            })
            .ToListAsync(cancellationToken);
        return new GetAllDealsQueryResponse(count, data);
    }
}