using BookStoreBL.Interfaces;
using BookstoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;


        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Author> GetAll()
        {
            return _authorService.GetAll();
        }
        [HttpGet("GetById")]
        public Author? GetById(int id)
        {
            return _authorService.GetbyId(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Author author)
        {
            _authorService.Add(author);
        }

        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _authorService.Delete(id);
        }
    }
}

