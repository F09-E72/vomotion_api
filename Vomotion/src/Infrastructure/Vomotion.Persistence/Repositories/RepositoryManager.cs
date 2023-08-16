using Vomotion.Domain.Repositories;

namespace Vomotion.Persistence.Repositories;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;
    // Add repositories like the unit of work

    public RepositoryManager(RepositoryDbContext context)
    {
        _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(context));
    }

    public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
}
