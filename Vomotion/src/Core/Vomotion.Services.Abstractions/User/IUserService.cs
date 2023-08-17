using Vomotion.Contracts;

namespace Vomotion.Services.Abstractions;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllAsync (CancellationToken cancellationToken);
}
