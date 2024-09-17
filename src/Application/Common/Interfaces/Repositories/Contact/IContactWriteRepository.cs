using Application.Common.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Common.Interfaces.Repositories.Contact
{
    public interface IContactWriteRepository : IWriteRepository<Domain.Entities.Contact>
    {
    }
}
