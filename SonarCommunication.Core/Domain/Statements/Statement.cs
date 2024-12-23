using SonarCommunication.Core.Domain.Helpers;

namespace SonarCommunication.Core.Domain.Statements;

/// <summary>
/// Обращение
/// </summary>
public class Statment : BaseEntity 
{
    /// <summary>
    /// Дата закрытия сообщения
    /// </summary>
    public DateTime DateClose {get; set;}
    /// <summary>
    /// Статус сообщения
    /// </summary>
    public StatementStatus StatmentStatus {get; set;}
    
    public long? StatmentImageId {get; set;}
    /// <summary>
    /// Описание сообщения
    /// </summary>
    public string Description {get; set;}
    /// <summary>
    /// Владелец
    /// </summary>
    public string Owner {get; set;}
}