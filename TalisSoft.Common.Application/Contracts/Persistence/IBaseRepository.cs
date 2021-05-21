using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TalisSoft.Common.Application.Contracts.Persistence
{
    public interface IBaseRepository<T> where T: class
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellation);
        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellation);
        Task<T> AddAsync(T entity, CancellationToken cancellation);
        Task UpdateAsync(T entity, CancellationToken cancellation);
        Task DeleteAsync(T entity, CancellationToken cancellation);
    }
}