using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.SearchGroups;
using SonarCommunication.DataAccess.Data;


namespace SonarCommunication.DataAccess.Repositories;

public class SearchGroupRepository : IRepository<SearchGroup>
{
    private DataContext _ctx;
    public SearchGroupRepository(DataContext ctx)
    {
        _ctx = ctx;
    }
    public Task<IList<SearchGroup>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SearchGroup> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<SearchGroup> AddAsync(SearchGroup entity)
    {
        throw new NotImplementedException();
    }

    public Task<SearchGroup> UpdateAsync(SearchGroup entity)
    {
        throw new NotImplementedException();
    }

    public Task<SearchGroup> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}
