using Simulacrum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Simulacrum.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<KnowledgeObject> KnowledgeObjects { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}