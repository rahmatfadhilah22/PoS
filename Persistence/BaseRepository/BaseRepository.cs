using Domain.BaseInterface.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Persistence.BaseRepository;
public class BaseRepository : IUnitOfWork
{
    private readonly DbContext _context;
    private IDbContextTransaction _transaction;

    public BaseRepository(DbContext context)
    {
        _context = context;
    }

    public async Task BeginTransaction()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }

    public async Task Commit()
    {
        try
        {
            await _context.SaveChangesAsync();
            await _transaction.CommitAsync();
        }
        catch
        {
            await _transaction.RollbackAsync();
            throw;
        }
        finally
        {
            await _transaction.DisposeAsync();
        }
    }

    public async Task Rollback()
    {
        await _transaction.RollbackAsync();
        await _transaction.DisposeAsync();
    }
}
