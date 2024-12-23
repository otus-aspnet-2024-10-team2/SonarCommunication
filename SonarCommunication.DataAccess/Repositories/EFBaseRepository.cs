using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain;
using SonarCommunication.DataAccess.Data;

namespace SonarCommunication.DataAccess.Repositories;

public class EFBaseRepository<T> : IBaseRepositories<T> where T : BaseEntity
{
    private DataContext _ctx;

    public EFBaseRepository(DataContext ctx)
    {
        _ctx = ctx;
    }
    //TODO: Сделать реализацию для каждого метода
    public Task<List<T>> GetAllStatementsAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateNewStatementAsync(T statement)
    {
        throw new NotImplementedException();
    }

    public Task ReadStatementAsync(T statement)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStatementAsync(T statement)
    {
        throw new NotImplementedException();
    }

    public Task DeleteStatementAsync(T statement)
    {
        throw new NotImplementedException();
    }
}