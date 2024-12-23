namespace SonarCommunication.Core.Domain.Helpers;

/// <summary>
/// Статусная модель сообщения
/// </summary>
public enum StatementStatus
{
    /// <summary>
    /// Сообщение создано, но в виде эфимерного типа, на стадии наполнения
    /// </summary>
    isEmpty = 0,
    /// <summary>
    /// Сообщение создано
    /// </summary>
    isCreated = 1,
    /// <summary>
    /// Сообщение на стадии проверки
    /// </summary>
    isCheck = 2,
    /// <summary>
    /// Cообщение в работе
    /// </summary>
    isProcess = 3,
    /// <summary>
    /// Сообщение закрыто
    /// </summary>
    isDone = 4,
    /// <summary>
    /// Сообщение содержит ошибку
    /// </summary>
    isError = 5,
}