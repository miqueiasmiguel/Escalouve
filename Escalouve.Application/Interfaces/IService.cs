namespace Escalouve.Application.Interfaces
{
    public interface IService<T>
    {
        Task<T> CreateAsync(T dto);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int? id);
        Task<T> UpdateAsync(T dto);
        Task DeleteAsync(int? id);
    }
}
