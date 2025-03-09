using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain;
using SonarCommunication.Core.Domain.Statements;
using SonarCommunication.DataAccess.Data;

namespace SonarCommunication.DataAccess.Repositories;

public class EFBaseRepository<T> : IBaseRepositories<T> where T : BaseEntity
{
    private DataContext _ctx;

    public EFBaseRepository(DataContext ctx)
    {
        _ctx = ctx;
    }
    /// <summary>
    /// Получить все сообщения
    /// </summary>
    /// <returns></returns>
    public async Task<List<T>> GetAllStatementsAsync()
    {
        return await _ctx.Set<T>().ToListAsync();
    }
    /// <summary>
    /// Создать новое сообщение
    /// </summary>
    /// <param name="statement"></param>
    public async Task CreateNewStatementAsync(T statement)
    {
        await _ctx.Set<T>().AddAsync(statement);
        await _ctx.SaveChangesAsync();  
    }

    public Task ReadStatementAsync(T statement)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Обновить сообщение
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    public async Task UpdateStatementAsync(T statement)
    {
        await _ctx.SaveChangesAsync();
    }
    /// <summary>
    /// Удалить сообщение
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task DeleteStatementAsync(T statement)
    {
        _ctx.Set<T>().Remove(statement);
        return _ctx.SaveChangesAsync();
    }

    /// <summary>
    /// Получить сообщение по конкретному ID
    /// </summary>
    /// <param name="id">ID сообщение</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<T?> GetStatmentFromIdAsync(long id)
    {
        var record = await _ctx.Set<T>().FirstOrDefaultAsync(x=> x.Id == id);
        return record;
    }
}