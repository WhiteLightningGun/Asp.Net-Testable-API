/*
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Testable_API.Controllers;
using Testable_API.Data;
using Testable_API.Repository;
using System.Collections.Generic;

namespace ApiTests
{
    public class BooksControllerTests
    {
        private readonly Mock<IDataRepository> mockRepo;
        private readonly BooksController controller;
        public BooksControllerTests()
        {
            mockRepo = new Mock<IDataRepository>();
            controller = new BooksController(mockRepo.Object);
        }

        [Fact]
        public void GetBooksRepo_ReturnsAllBooks()
        {
            // Arrange
            Book[] booksList =
            [
                new() { Id = 1, Title = "Book 1", Author = "Author 1", ISBN = "1234567890123" },
                new() { Id = 2, Title = "Book 2", Author = "Author 2", ISBN = "1234567890124" }
            ];

            mockRepo.Setup(repo => repo.GetAllBooks()).Returns(booksList);

            // Act
            var result = controller.GetBooksRepo();

            // Assert, testing to see if controller method returns IEnumerable<Book> and that is has the correct number of items
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Book>>>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Book>>(actionResult.Value);
            Assert.Equal(booksList.Length, ((List<Book>)model).Count);
        }
    }
}

*/