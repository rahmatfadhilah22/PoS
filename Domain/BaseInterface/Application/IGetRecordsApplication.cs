using Domain.Models;

namespace Domain.BaseInterface.Persistence
{
    public interface IGetRecordsApplication<T>
    {
        Task<IEnumerable<T>> GetRecords(RecordsParameter param);
    }

    
}
