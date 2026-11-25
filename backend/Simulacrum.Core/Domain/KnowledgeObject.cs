using Simulacrum.Domain.Common;

namespace Simulacrum.Domain.Entities;

public class KnowledgeObject: IWorkspaceObject
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public string? Message { get; set; }
    public string? Name { get; set; }
}
