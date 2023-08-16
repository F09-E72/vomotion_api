using Microsoft.EntityFrameworkCore;

namespace Vomotion.Persistence;

public sealed class RepositoryDbContext : DbContext
{
    public RepositoryDbContext(DbContextOptions options)
        : base(options)
    {
    }

    // Add dbset here

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
}
