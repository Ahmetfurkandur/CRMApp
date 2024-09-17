using Application.Common.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Common.Interfaces.Repositories.Contact
{
    public interface IContactReadRepository : IReadRepository<Domain.Entities.Contact>
    {
    }
}
