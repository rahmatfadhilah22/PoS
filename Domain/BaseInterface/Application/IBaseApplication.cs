

namespace Domain.BaseInterface.Application;

public interface IBaseApplication<T>
{
    Task<T> GetRecord(Guid id);
    Task<int> Insert(T model);
    Task<int> Update(T model);
}
