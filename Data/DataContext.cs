using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext: DbContext, IDataContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }
}   