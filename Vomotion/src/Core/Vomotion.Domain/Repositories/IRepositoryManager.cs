namespace Vomotion.Domain.Repositories;
public interface IRepositoryManager
{
    IUnitOfWork UnitOfWork { get; }
}
