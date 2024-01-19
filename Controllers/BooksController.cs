using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Repository;

namespace Testable_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IDataContext dataContext;
        private IDataRepository dataRepo;
        public BooksController(IDataContext _datacontext, IDataRepository _dataRepo)
        {
            dataContext = _datacontext;
            dataRepo = _dataRepo;
        }
        /*
        [HttpGet(Name = "GetBooks")]
        public IEnumerable<Book> GetBooks()
        {
            var BookList = dataContext.Books.Select(x => x).ToArray();
            return BookList;
        }
        */
        [HttpGet(Name = "BooksRepo")]
        public IEnumerable<Book> GetBooksRepo()
        {
            var BookList = dataRepo.GetAllBooks();
            return BookList;
        }
    }
}
