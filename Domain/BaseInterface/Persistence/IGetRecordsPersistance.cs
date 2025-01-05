using Domain.Models;

namespace Domain.BaseInterface.Persistence
{
    public interface IGetRecordsPersistence<T>
    {
        Task<IEnumerable<T>> GetRecords(RecordsParameter param);
    }

    
}
