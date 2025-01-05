namespace Domain.BaseInterface.Persistence
{
    public interface IDeletePersistence
    {
        Task<int> Delete(int Id);
    }
}
