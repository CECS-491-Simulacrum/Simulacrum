namespace Simulacrum.Application.DTOs;

// backend output, ObjectController maps a created KnowledgeObject into a response of this data type
public class ObjectDto
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string? Message { get; set; }
    public string? Name { get; set; }
}