using Microsoft.EntityFrameworkCore;

namespace Testable_API.Data;

public class DataContext: DbContext, IDataContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }
}   