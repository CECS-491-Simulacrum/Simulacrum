using Simulacrum.Application.Interfaces;
using Simulacrum.Application.DTOs;
using Simulacrum.Domain.Entities;

namespace Simulacrum.Application.Services;

public class ObjectService
{
    private readonly IApplicationDbContext _dbcontext;

    public ObjectService(IApplicationDbContext dbcontext) => _dbcontext = dbcontext;

    // create knowledgeobject from input dto, save it, and return the saved entity
    public async Task<KnowledgeObject> CreateObjectAsync(CreateObjectDto request)
    {
        var knowledgeObject = new KnowledgeObject
        {
            Name = request.Name,
            Message = request.Message,
        };

        _dbcontext.KnowledgeObjects.Add(knowledgeObject); // track for insertion

        await _dbcontext.SaveChangesAsync(); // persist added changes

        return knowledgeObject;
    }
}