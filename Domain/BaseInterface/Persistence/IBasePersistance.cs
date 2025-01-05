

using System.Data;

namespace Domain.BaseInterface.Persistence;

public interface IBasePersistance<T>
{
    Task<T> GetRecord(Guid id);
    Task<int> Insert(T model);
    Task<int> Update(T model);
}
