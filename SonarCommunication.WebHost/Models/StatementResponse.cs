using SonarCommunication.Core.Domain.Helpers;

namespace SonarCommunication.WebHost.Models;

public class StatementResponse
{
    public ulong Id { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public StatementStatus Status { get; set; }
    
    public string Desctiption { get; set; }
    
    public string Owner {get; set;}
    
    
}