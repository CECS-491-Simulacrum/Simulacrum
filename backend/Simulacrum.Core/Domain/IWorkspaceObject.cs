namespace Simulacrum.Domain.Common;

public interface IWorkspaceObject
{
    public Guid Id { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public string? Message { get; set; }
    public string? Name { get; set; }
}