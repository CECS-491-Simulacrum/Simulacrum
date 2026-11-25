using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Simulacrum.Domain.Entities;

// Creating a simple example object to send to the DB
[Table("TestObjects")]
public class TestObject : BaseModel
{
    // Reference: https://supabase.com/docs/reference/csharp/initializing
    [PrimaryKey("id")]
    public Guid Id {  get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; } = string.Empty;
    
    [Column("tags")]
    public ICollection<String> Tags  { get; set; }
    
    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
}