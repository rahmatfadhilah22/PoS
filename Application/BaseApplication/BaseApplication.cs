namespace Application.BaseApplication;

public class BaseApplication
{
    protected Guid GetGuid()
    {
        Guid guid = new Guid();
        return guid;

    }
}