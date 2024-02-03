using BookStoreBL.Interfaces;
using BookstoreModels.Models.Requests;
using BookstoreModels.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class LibraryController : ControllerBase
    {
        public readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }


        [HttpPost("GetAllBooksByAuthorId")]
        public GetAllBooksByAuthorResponse GetAllBooksByAuthorAfterDate(GetAllBooksByAuthorRequest request)
        {
            return _libraryService.GetAllBooksByAuthorAfterDate(request);
        }

        [HttpPost("TestEndPoint")]
        public string TestEndPoint([FromBody]

            GetAllBooksByAuthorRequest request)
        {
            return "Ok";
        }
    }


}