using Vomotion.Domain.Repositories;

namespace Vomotion.Persistence.Repositories;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;
    private readonly Lazy<IUserRepository> _lazyUserRepository;
    public RepositoryManager(RepositoryDbContext context)
    {
        _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(context));
        _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
    }

    public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    public IUserRepository UserRepository => _lazyUserRepository.Value;
}
