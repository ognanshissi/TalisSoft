using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalisSoft.Common.Application.Contracts.Persistence;

namespace TalisSoft.Common.Persistence.Repositories
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> 
        where T: class 
        where TContext: DbContext
    {
        protected readonly TContext Context;

        protected BaseRepository(TContext context)
        {
            Context = context;
        }
        
        public virtual async Task<T> GetByIdAsync(Guid id, CancellationToken cancellation)
        {
            return await Context.Set<T>().FindAsync(id, cancellation).ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellation)
        {
            return await Context.Set<T>().ToListAsync(cancellation).ConfigureAwait(false);
        }

        public virtual async Task<T> AddAsync(T entity, CancellationToken cancellation)
        {
            await Context.Set<T>().AddAsync(entity, cancellation);
            await Context.SaveChangesAsync(cancellation).ConfigureAwait(false);
            return entity;
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellation)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync(cancellation).ConfigureAwait(false);
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellation)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync(cancellation).ConfigureAwait(false);
        }
    }
}