using Vomotion.Domain.Repositories;
using Vomotion.Services.Abstractions;

namespace Vomotion.Services;
public sealed class ServiceManager : IServiceManager
{
    private ServiceManager(IRepositoryManager repositoryManager) 
    {
    
    }
}
