﻿namespace Application.Common.Interfaces.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        Task<bool> RemoveAsync(Guid id);
        bool RemoveRange(List<T> entities);
        bool Update(T entity);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
