using Simulacrum.Domain.Common;

namespace Simulacrum.Domain.Entities;

public class KnowledgeObject: IWorkspaceObject
{
    public Guid Id { get; } = Guid.NewGuid();
}
