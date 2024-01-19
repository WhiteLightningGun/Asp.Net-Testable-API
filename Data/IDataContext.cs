using Microsoft.EntityFrameworkCore;
using Testable_API.Controllers;

namespace API.Data;

public interface IDataContext
{
    DbSet<Book> Books {get; set;}
}