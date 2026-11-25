using Simulacrum.Application.Interfaces;
using Simulacrum.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Simulacrum.Infrastructure.Persistence;

/** Additional reference from this repository:
 * https://github.com/jasontaylordev/CleanArchitecture/blob/main/src/Infrastructure/Data/ApplicationDbContext.cs
 *
 * Data annotations or fluent API to configure a model:
 * https://learn.microsoft.com/en-us/ef/core/modeling/#use-fluent-api-to-configure-a-model
 *
 * Migrations Overview (for code-first database):
 * https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
 */
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    // receive configuration info like connection string & provider through DI
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<KnowledgeObject> KnowledgeObjects => Set<KnowledgeObject>();

    // no specific configurations are made, so EF uses default mapping for KnowledgeObjects
    // customize the mappings with fluent API or data annotations
    // after any model changes, generate and apply a migration. they're like git changes to the database
    // refer to the developer guide for migration instructions

}