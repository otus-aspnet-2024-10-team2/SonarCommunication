using Mapster;
using Microsoft.AspNetCore.Mvc;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.SearchGroups;
using SonarCommunication.WebHost.Models;

namespace SonarCommunication.WebHost.Controllers;

/// <summary>
/// Группы поиска
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
public class SearchGroupController : ControllerBase
{
    private readonly ILogger<SearchGroupController> _logger;
    private readonly IRepository<SearchGroup> _repository;

    public SearchGroupController(ILogger<SearchGroupController> logger, IRepository<SearchGroup> repository)
    {
        _logger = logger;
        _repository = repository;
    }

    /// <summary>
    /// Получение информации о группе поиска по ID
    /// </summary>
    /// <param name="groupId">Идентификатор группы</param>
    /// <returns></returns>
    [HttpGet("{groupId}")]
    public async Task<ActionResult<SearchGroupDto>> GetSearchGroup(long groupId)
    {
        var group = await _repository.GetAsync(groupId);
        if (group == null)
            return NotFound();
        return Ok(group.Adapt<SearchGroupDto>());
    }

    /// <summary>
    /// Создание новой группы поиска.
    /// </summary>
    /// <param name="groupDto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<SearchGroupDto>> CreateSearchGroup([FromBody] SearchGroupDto groupDto)
    {
        var createdGroup = await _repository.AddAsync(groupDto.Adapt<SearchGroup>());
        if (createdGroup == null)
            return NoContent();
        return Ok(createdGroup.Adapt<SearchGroupDto>());
    }

    /// <summary>
    /// Обновление группы поиска
    /// </summary>
    /// <param name="groupDto"></param>
    /// <returns></returns>
    [HttpPut("{groupId:long}/update")]
    public async Task<ActionResult<SearchGroupDto>> UpdateSearchGroup(long groupId, [FromBody] SearchGroupDto groupDto)
    {
        var updatedGroup = await _repository.UpdateAsync(groupDto.Adapt<SearchGroup>());
        if (updatedGroup == null)
            return NotFound();
        return Ok(updatedGroup.Adapt<SearchGroupDto>());
    }

    /// <summary>
    /// Удаление группы поиска
    /// </summary>
    /// <param name="groupId"></param>
    /// <returns></returns>
    [HttpDelete("{groupId:long}/delete")]
    public async Task<IActionResult> DeleteSearchGroup(long groupId)
    {
        var deletedGroup = await _repository.DeleteAsync(groupId);
        if (deletedGroup == null)
            return NotFound();
        return Ok();
    }
}
