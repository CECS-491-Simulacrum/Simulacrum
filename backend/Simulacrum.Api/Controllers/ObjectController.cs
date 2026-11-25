using Microsoft.AspNetCore.Mvc;
using Simulacrum.Application.DTOs;
using Simulacrum.Application.Services;
using Simulacrum.Domain.Entities;

namespace Simulacrum.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ObjectController : ControllerBase
{
    private readonly ObjectService _service;

    public ObjectController(ObjectService service) => _service = service;
    
    [HttpPost]
    public async Task<ActionResult<ObjectDto>> PostObject(CreateObjectDto request)
    {
        KnowledgeObject created = await _service.CreateObjectAsync(request);

        // map created KnowledgeObject into a ObjectDto to return data in `ObjectDto` format
        ObjectDto response = new ObjectDto
        {
            Id = created.Id,
            CreatedAt = created.CreatedAt,
            Name = created.Name,
            Message = created.Message
        };

        return Ok(response);
        
    }

}
