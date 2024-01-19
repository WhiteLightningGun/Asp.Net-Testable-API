namespace Testable_API.Repository;
using Testable_API.Data;

public class DataRepository : IDataRepository
{
    private IDataContext dataContext;
    public DataRepository(IDataContext _dataContext)
    {
        dataContext = _dataContext;
    }
    public IEnumerable<Book> GetAllBooks()
    {
        IEnumerable<Book> BookList = dataContext.Books.Select(x => x).ToArray();
        return BookList;
    }

}