using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.SearchGroups;
using SonarCommunication.DataAccess.Data;


namespace SonarCommunication.DataAccess.Repositories;

public class GroupMemberRepository : IRepository<GroupMember>
{
    private DataContext _ctx;
    public GroupMemberRepository(DataContext ctx)
    {
        _ctx = ctx;
    }

    public Task<IList<GroupMember>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GroupMember> GetAsync(long id)
    {
        throw new NotImplementedException();
    }


    public Task<GroupMember> AddAsync(GroupMember entity)
    {
        throw new NotImplementedException();
    }

    public Task<GroupMember> UpdateAsync(GroupMember entity)
    {
        throw new NotImplementedException();
    }

    public Task<GroupMember> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}
