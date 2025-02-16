using Mapster;
using Microsoft.AspNetCore.Mvc;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.SearchGroups;
using SonarCommunication.WebHost.Models;

namespace SonarCommunication.WebHost.Controllers;

public class GroupMemberController : ControllerBase
{
    private readonly ILogger<GroupMemberController> _logger;
    private readonly IRepository<GroupMember> _repository;
    public GroupMemberController(ILogger<GroupMemberController> logger, IRepository<GroupMember> baseRepository)
    {
        _logger = logger;
        _repository = baseRepository;
    }

    /// <summary>
    /// Получение информации об участнике группы по ID
    /// </summary>
    /// <param name="memberId">Идентификатор участника</param>
    /// <returns></returns>
    [HttpGet("{memberId}")]
    public async Task<ActionResult<GroupMemberDto>> GetGroupMember(long memberId)
    {
        var group = await _repository.GetAsync(memberId);
        if (group == null)
            return NotFound();
        return Ok(group.Adapt<GroupMemberDto>());
    }

    /// <summary>
    /// Добавление участника в группу поиска
    /// </summary>
    /// <param name="groupId"></param>
    /// <returns></returns>
    [HttpPost("{groupId:long}/members")]
    public async Task<ActionResult<GroupMemberDto>> AddGroupMember([FromBody] GroupMemberDto memberDto)
    {
        var addedMember = await _repository.AddAsync(memberDto.Adapt<GroupMember>());
        if (addedMember == null)
            return NoContent();
        return Ok(addedMember.Adapt<GroupMemberDto>());
    }

    /// <summary>
    /// Обновление информации об участнике
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns></returns>
    [HttpPut("{memberId:long}/update")]
    public async Task<ActionResult<GroupMemberDto>> UpdateGroupMember(long memberId, [FromBody] GroupMemberDto memberDto)
    {
        var updatedMember = await _repository.UpdateAsync(memberDto.Adapt<GroupMember>());
        if (updatedMember == null)
            return NotFound();
        return Ok(updatedMember.Adapt<GroupMemberDto>());
    }

    /// <summary>
    /// Удаление участника из группы
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns></returns>
    [HttpDelete("{memberId:long}/delete")]
    public async Task<IActionResult> DeleteGroupMember(long memberId)
    {
        var deletedMember = await _repository.DeleteAsync(memberId);
        if (deletedMember == null)
            return NotFound();
        return Ok();
    }
}
