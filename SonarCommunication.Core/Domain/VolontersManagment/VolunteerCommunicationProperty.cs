namespace SonarCommunication.Core.Domain.VolontersManagment;
/// <summary>
/// Сущность, описывающая способ общения с волонтером
/// </summary>
public class VolunteerCommunicationProperty
{
    /// <summary>
    /// Через телеграм
    /// </summary>
    public bool telegramCmn { get; set; }
    /// <summary>
    /// Ник в телеге
    /// </summary>
    public string? TelegramAccount { get; set; }
    /// <summary>
    /// Через whatsUp
    /// </summary>
    public bool WhtasUpCmn { get; set; }
    /// <summary>
    /// Аккаунт в whatsup
    /// </summary>
    public string? WhatsUpAccount { get; set; }
    /// <summary>
    /// Через СМС
    /// </summary>
    public bool SmsCmn { get; set; }
    /// <summary>
    /// Через телефон
    /// </summary>
    public bool TelephoneCmn { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string? TelephoneNumber { get; set; }
}