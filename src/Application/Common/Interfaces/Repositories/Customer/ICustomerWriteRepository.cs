using Application.Common.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Common.Interfaces.Repositories.Customer
{
    public interface ICustomerWriteRepository : IWriteRepository<Domain.Entities.Customer>
    {
    }
}
