namespace SonarCommunication.Core.Domain.VolontersManagment;
/// <summary>
/// Сущность описывающая волнтера
/// </summary>
public class Volunteer : BaseEntity
{
    /// <summary>
    /// Ид волонтера в рамках БД
    /// </summary>
    public ulong Id { get; set; }
    /// <summary>
    /// Имя волонтера
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия (при желании)
    /// </summary>
    public string SecondName { get; set; }
    /// <summary>
    /// Ник 
    /// </summary>
    public string NickName { get; set; }
    /// <summary>
    /// Способ общения с волонтером 
    /// </summary>
    public VolunteerCommunicationProperty CommunicationProperty { get; set; } 
    /// <summary>
    /// Регион нахождения волонтера
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// Город нахождения 
    /// </summary>
    public string? City { get; set; }
    /// <summary>
    /// Район
    /// </summary>
    public string? District { get; set; }
}