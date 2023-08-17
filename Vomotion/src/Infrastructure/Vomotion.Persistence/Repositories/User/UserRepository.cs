using Microsoft.EntityFrameworkCore;
using Vomotion.Domain.Entities;
using Vomotion.Domain.Repositories;

namespace Vomotion.Persistence.Repositories;

internal sealed class UserRepository : IUserRepository
{
    private readonly RepositoryDbContext _context;

    public UserRepository(RepositoryDbContext context) => _context = context;

    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default) => 
        await _context
            .Users
            .ToListAsync(cancellationToken);

    public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default) => 
        await _context
            .Users
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);

    public void Insert(User user) => _context.Users.AddAsync(user);

    public void Remove(User user) => _context.Users.Remove(user);
}
