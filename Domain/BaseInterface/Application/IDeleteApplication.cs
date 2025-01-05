namespace Domain.BaseInterface.Application
{
    public interface IDeleteApplication<T>
    {
        Task<int> Delete(int Id);

    }

}
