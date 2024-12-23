namespace SonarCommunication.Core.Domain.VolontersManagment;

public class VolunteerSquad : BaseEntity
{
    /// <summary>
    /// ИД обращения
    /// </summary>
    public ulong StatementId { get; set; }
    /// <summary>
    /// Команда волонтеров
    /// </summary>
    public List<Volunteer> VolunteersCommand { get; set; }
    /// <summary>
    /// Ид руководителя поисковой группы (при наличаи)
    /// </summary>
    public long? VolunteerCommanderId { get; set; }
}