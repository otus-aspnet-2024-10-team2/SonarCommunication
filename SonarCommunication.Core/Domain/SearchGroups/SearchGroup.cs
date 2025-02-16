namespace SonarCommunication.Core.Domain.SearchGroups;

public class SearchGroup: BaseEntity
{
    public int GroupId { get; set; }
    public int RequestId { get; set; }
    public int LeaderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    /*
    public virtual SearchRequest SearchRequest { get; set; }
    public virtual User Leader { get; set; }
    public virtual ICollection<GroupMember> Members { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }

    */
}
