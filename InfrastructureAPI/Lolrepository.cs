using DomainAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureAPI
{
    public class Lolrepository<T> : ILolRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;

        public Lolrepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
     
        public async Task<List<T>> ListAsync(ISpecification<T> spec)
        {
            IQueryable<T> query = _dbContext.Set<T>().AsNoTracking();


            if (spec.Criteria != null)
                query = query.Where(spec.Criteria);


            if (spec.OrderBy != null)
                query = query.OrderBy(spec.OrderBy);
            else if (spec.OrderByDescending != null)
                query = query.OrderByDescending(spec.OrderByDescending);

            if (spec.IsPagingEnabled)
                query = query.Skip(spec.Skip).Take(spec.Take);
            if (spec.Include != null)
            {
                foreach (var include in spec.Include)
                {
                    query = query.Include(include);
                }
            }
            if (spec.GroupBy  != null)
            query = query.GroupBy(spec.GroupBy).SelectMany(g => g);
              




            return await query.ToListAsync();
        }

        public async Task<T> Obtenerporid(int id)
        {
         
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
