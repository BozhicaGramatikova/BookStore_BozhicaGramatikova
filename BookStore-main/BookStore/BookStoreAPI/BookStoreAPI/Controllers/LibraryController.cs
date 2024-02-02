using BookStoreBL.Interfaces;
using BookstoreModels.Models.Requests;
using BookstoreModels.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthorAndDate")]
        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAndDate([FromBody]
                GetAllBooksByAuthorRequest request)
        {
            return _libraryService
                .GetAllBooksByAuthorAfterReleaseDate(request);
        }

        [HttpPost("SomeEndpoint")]
        public string GetSomeData([FromBody] TestRequest request)
        {
            return "Ok";
        }
    }
}
