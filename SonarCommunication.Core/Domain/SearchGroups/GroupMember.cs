namespace SonarCommunication.Core.Domain.SearchGroups;

/// <summary>
/// Участник группы поиска
/// </summary>
public class GroupMember : BaseEntity
{
    public int MemberId { get; set; }
    public int GroupId { get; set; }
    public int UserId { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}