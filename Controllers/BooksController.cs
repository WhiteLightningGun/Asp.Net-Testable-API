using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Repository;

namespace Testable_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IDataRepository dataRepo;
        public BooksController(IDataRepository _dataRepo)
        {
            dataRepo = _dataRepo;
        }

        [HttpGet(Name = "BooksRepo")]
        public IEnumerable<Book> GetBooksRepo()
        {
            var BookList = dataRepo.GetAllBooks();
            return BookList;
        }
    }
}
