using Simulacrum.Application.Interfaces;
using Simulacrum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Simulacrum.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    // receive configuration info like connection string & provider through DI
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    // public DbSet<KnowledgeObject> Objects => Set<KnowledgeObject>();
}