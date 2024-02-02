using BookstoreModels.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse?
           GetAllBooksByAuthorAfterReleaseDate(
               GetAllBooksByAuthorRequest request);

        int CheckBookCount(int input);
    }
}
