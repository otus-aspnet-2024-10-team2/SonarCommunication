using SonarCommunication.Core.Domain;

namespace SonarCommunication.Core.Abstraction.Repositories;
/// <summary>
/// Базовый интерфейс команд
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBaseRepositories<T> where T : BaseEntity
{
    Task<List<T>> GetAllStatementsAsync();
    
    Task CreateNewStatementAsync(T statement);
    
    Task ReadStatementAsync(T statement);
    
    Task UpdateStatementAsync(T statement);
    
    Task DeleteStatementAsync(T statement);
}