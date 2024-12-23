namespace SonarCommunication.Core.Domain.Statements;
/// <summary>
/// Сообщения в рамках обращения
/// </summary>
public class StatementMessage : BaseEntity
{
    /// <summary>
    /// ИД обращения
    /// </summary>
    public ulong StatementId { get; set; }
    /// <summary>
    /// Сообщение от волонтера/хозяина
    /// </summary>
    public string Message { get; set; }
    /// <summary>
    /// Ид волонтера
    /// </summary>
    public long? VolonterId { get; set; }
    /// <summary>
    /// GPS координаты
    /// </summary>
    public string? GPSLocation { get; set; }
    /// <summary>
    /// Картинка
    /// </summary>
    public StatementImage Img {get; set;}
}