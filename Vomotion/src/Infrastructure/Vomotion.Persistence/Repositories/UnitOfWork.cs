using Vomotion.Domain.Repositories;

namespace Vomotion.Persistence.Repositories;

internal sealed class UnitOfWork : IUnitOfWork
{
    private readonly RepositoryDbContext _context;

    public UnitOfWork(RepositoryDbContext context) => _context = context;

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
        _context.SaveChangesAsync(cancellationToken);
}
