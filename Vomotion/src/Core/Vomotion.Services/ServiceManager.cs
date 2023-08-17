using Vomotion.Domain.Repositories;
using Vomotion.Services.Abstractions;

namespace Vomotion.Services;
public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IUserService> _lazyUserService;
    public ServiceManager(IRepositoryManager repositoryManager) 
    {
        _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager));
    }

    public IUserService UserService => _lazyUserService.Value;
}
