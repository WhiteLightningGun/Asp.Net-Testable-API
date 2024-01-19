namespace Testable_API.Repository;
using Testable_API.Data;

public interface IDataRepository
{
    public IEnumerable<Book> GetAllBooks();
}