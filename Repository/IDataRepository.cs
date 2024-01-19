namespace API.Repository;
using API.Data;

public interface IDataRepository
{
    public Book[] GetAllBooks();
}