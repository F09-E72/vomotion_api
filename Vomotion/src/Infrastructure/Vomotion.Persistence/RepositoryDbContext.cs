using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Vomotion.Domain.Entities;

namespace Vomotion.Persistence;

public sealed class RepositoryDbContext : DbContext
{
    public RepositoryDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; } 
    public DbSet<Notebook> Notebooks { get; set; }
    public DbSet<FlashCard> FlashCards { get; set; }
    public DbSet<Language> Languages { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
}

public class RepositoryDbContextFactory : IDesignTimeDbContextFactory<RepositoryDbContext>
{
    public RepositoryDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<RepositoryDbContext>();

        var connectionString = Domain.Settings.EnvironmentVariables.ConnectionString;

        optionsBuilder.UseNpgsql(connectionString);

        return new RepositoryDbContext(optionsBuilder.Options);
    }
}