namespace Escalouve.Domain.Interfaces;

public interface IRepository<T>
{
    Task<T> CreateAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}
