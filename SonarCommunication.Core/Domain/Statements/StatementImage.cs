using System.Reflection.Metadata;

namespace SonarCommunication.Core.Domain.Statements;
/// <summary>
/// Сущность для хранения фото в рамках одного обращения
/// </summary>
public class StatementImage : BaseEntity
{
    //TODO: Надо подумать, стоить ли Blob тащить сюда???
    /// <summary>
    /// Картинка
    /// </summary>
    public Blob Image { get; set; }
    /// <summary>
    /// ИД обращения
    /// </summary>
    public ulong StatementId { get; set; }
    /// <summary>
    /// Ид коментария к фото
    /// </summary>
    public string? Comment { get; set; }
}