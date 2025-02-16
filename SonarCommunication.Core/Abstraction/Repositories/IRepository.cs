using SonarCommunication.Core.Domain;

namespace SonarCommunication.Core.Abstraction.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    Task<IList<T>> GetAllAsync();

    Task<T> GetAsync(long id);

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task<T> DeleteAsync(long id);
}