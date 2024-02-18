using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.db
{
    public interface IEntity<TIndex>
    {
        TIndex Id { get; set; }
    }

    public interface IEFCoreService<TEntity, TIndex>
    {
        Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> FetchAsync(TIndex id);
        IQueryable<TEntity> QueryableWhere(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }

    public class EFCoreService<TEntity, TIndex> : IEFCoreService<TEntity, TIndex> 
        where TEntity : class, IEntity<TIndex>, new()
    {
        private readonly ApplicationContext _context;
        private DbSet<TEntity> _dbSet => _context.Set<TEntity>();
        public EFCoreService(
            ApplicationContext context
        )
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<TEntity?> FetchAsync(TIndex id)
        {
            var entity = await _dbSet.FindAsync(id);

            return entity;
        }

        public IQueryable<TEntity> QueryableWhere(
            Expression<Func<TEntity, bool>> predicate
        ) => _dbSet.Where(predicate);

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var created = _context.Add(entity);

            await _context.SaveChangesAsync();

            return created.Entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updated = _context.Update(entity);

            await _context.SaveChangesAsync();

            return updated.Entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}