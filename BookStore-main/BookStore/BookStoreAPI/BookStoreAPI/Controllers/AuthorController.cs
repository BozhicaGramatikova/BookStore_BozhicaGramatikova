using BookStoreBL.Interfaces;
using BookstoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       

        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;
        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        [HttpGet( "GetById")]
        public Author? GetById(int id)
        {
            return _authorService.GetById(id);
        }
        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _authorService.Delete(id);
        }
    }
}
