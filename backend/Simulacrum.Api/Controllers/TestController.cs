using Microsoft.AspNetCore.Mvc;
using Simulacrum.Application.Services;
using Simulacrum.Domain.Entities;
using Supabase;

namespace Simulacrum.Api.Controllers;


[ApiController]
[Route("[controller]")] // Basically opens a Route based on the name of this controller, (i.e., /Test/)
public class TestController : ControllerBase
{
    private readonly Client _client;

    // Constructor
    public TestController(Client client)
    {
        _client = client;
    }

    // Defining behavior for post
    [HttpPost("send")]
    public async Task<IActionResult> Send([FromBody] TestObject entity)
    {
        // Fill out UUID if not provided (Probably shouldn't be provided anyways)
        if (entity.Id == Guid.Empty) entity.Id = Guid.NewGuid();
        
        // Fill out timestamp if not provided
        if (entity.CreatedAt ==  DateTimeOffset.MinValue) entity.CreatedAt = DateTime.Now;

        // Inserting the object into the TestObjects table
        await _client.From<TestObject>().Upsert(entity);

        return Ok(new { message = "Successfully pushed to the Database", id = entity.Id });
    }

    // Defining behavior for get (Specifically when querying by UUID)
    [HttpGet("{id}")]
    public async Task<IActionResult> Retrieve(Guid id)
    {
        // Retrieve the object by ID
        var result = await _client.From<TestObject>().Where(x => x.Id == id).Get();
        
        // Store the result as a readable object.
        var entity = result.Models.FirstOrDefault();
        if (entity == null) return NotFound(new { message = "Object Not Found" });

        return Ok(result.Model);
    }
    
    // Defining aditional GET behavior, this time by name
    [HttpGet("name")]
    public async Task<IActionResult> RetrieveByName([FromQuery] string name)
    {
        // Retrieve the object by name
        var result = await _client.From<TestObject>().Where(x => x.Name == name).Get();
        
        // Store the result as a readable object.
        var entity = result.Models.FirstOrDefault();
        if (entity == null) return NotFound(new { message = "Object Not Found" });
        
        return Ok(result.Model);
    }
}
