using Vomotion.Domain.Entities;

namespace Vomotion.Domain.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsync (int id, CancellationToken cancellationToken = default);
    void Insert(User user);
    void Remove(User user);
}
