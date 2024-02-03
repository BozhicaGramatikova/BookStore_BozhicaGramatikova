using BookStoreBL.Interfaces;
using BookstoreModels.Models.Requests;
using BookstoreModels.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public LibraryService(
            IAuthorService authorService,
            IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public int CheckAuthorCount(int input)
        {
            throw new NotImplementedException();
        }

        public int CheckBookCount(int input)
        {
            if (input < 0) return 0;

            var bookCount = _bookService.GetAll();

            return bookCount.Count + input;
        }

        public GetAllBooksByAuthorResponse GetAllBooksByAuthorAfterDate(GetAllBooksByAuthorRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(
                GetAllBooksByAuthorRequest request)
        {
            var response = new GetAllBooksByAuthorResponse
            {
                Author = _authorService
                    .GetbyId(request.AuthorId),
                Books = _bookService
                    .GetAllByAuthorAfterReleaseDate(
                        request.AuthorId,
                        request.DateAfter)
            };

            return response;
        }
    }
}
