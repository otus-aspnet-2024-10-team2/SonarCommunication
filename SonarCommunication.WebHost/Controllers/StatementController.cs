using Microsoft.AspNetCore.Mvc;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.Statements;
using SonarCommunication.WebHost.Models;

namespace SonarCommunication.WebHost.Controllers;
/// <summary>
/// Обращения
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
public class StatementController : ControllerBase
{
    private readonly ILogger<StatementController> _logger;
    private readonly IBaseRepositories<Statment> _baseRepository;

    public StatementController(ILogger<StatementController> logger, IBaseRepositories<Statment> baseRepository)
    {
        _logger = logger;
        _baseRepository = baseRepository;
    }

    
    /// <summary>
    /// Получить все обращения
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<StatementResponse>> GetAllStatementsAsync()
    {
        var statements = await _baseRepository.GetAllStatementsAsync();
        return Ok(statements);
    }
}