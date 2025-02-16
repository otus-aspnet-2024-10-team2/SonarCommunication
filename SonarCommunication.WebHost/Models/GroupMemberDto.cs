namespace SonarCommunication.WebHost.Models;

/// <summary>
/// Модель Участник группы поиска
/// </summary>
public class GroupMemberDto
{
    public int MemberId { get; set; }
    public int GroupId { get; set; }
    public int UserId { get; set; }
    public string Role { get; set; }
}
