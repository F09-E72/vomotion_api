using Vomotion.Contracts;
using Vomotion.Domain.Repositories;
using Vomotion.Services.Abstractions;
using Mapster;

namespace Vomotion.Services;

internal sealed class UserService : IUserService
{
    private readonly IRepositoryManager _repositoryManager;

    public UserService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

    public async Task<IEnumerable<UserDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var users = await _repositoryManager.UserRepository.GetAllAsync(cancellationToken);
        
        var usersDto = users.Adapt<IEnumerable<UserDto>>();
    
        return usersDto;
    }
}
