namespace Simulacrum.Application.DTOs;

// API input, this dto is used by ObjectService to create a KnowledgeObject
public class CreateObjectDto
{
    public string? Message { get; set; }
    public string? Name { get; set; }
}