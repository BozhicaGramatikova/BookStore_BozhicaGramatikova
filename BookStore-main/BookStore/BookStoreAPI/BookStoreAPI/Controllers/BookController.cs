using BookStoreBL.Interfaces;
using BookstoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("Get All")]
        public IEnumerable<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book)
        {
            _bookService.Add(book);
        }

        [HttpGet("GetById")]
        public Book? GetById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpDelete("Delete")]
        public void DeleteById(int id)
        {
            _bookService.Remove(id);
        }

    }
}