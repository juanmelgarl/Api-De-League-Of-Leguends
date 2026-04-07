using DomainAPI.Interfaces;
using InfrastructureAPI;
namespace DomainAPI.Interfaces
{
    public interface ILolRepository<T> where T : class
    {
    
        Task<List<T>> ListAsync(ISpecification<T> spec);
  
        Task<T?> Obtenerporid(int id);
        Task Update(T entity);
        Task Delete(T entity);
        Task Create(T entity);
    }
}
