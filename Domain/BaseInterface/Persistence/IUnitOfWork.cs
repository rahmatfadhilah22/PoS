
namespace Domain.BaseInterface.Persistence;
public interface IUnitOfWork
{
    Task BeginTransaction();
    Task Commit();
    Task Rollback();
}
