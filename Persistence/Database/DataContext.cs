using Microsoft.EntityFrameworkCore;

namespace Persistennce;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}