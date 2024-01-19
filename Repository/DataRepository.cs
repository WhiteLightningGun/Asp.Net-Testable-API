namespace API.Repository;
using API.Data;

public class DataRepository : IDataRepository
{
    private IDataContext dataContext;
    public DataRepository(IDataContext _dataContext)
    {
        dataContext = _dataContext;
    }
    public Book[] GetAllBooks()
    {
        var BookList = dataContext.Books.Select(x => x).ToArray();
        return BookList;
    }

}