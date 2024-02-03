using BookstoreModels.Models.Requests;
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
        public GetAllBooksByAuthorResponse
            GetAllBooksByAuthorAfterDate(GetAllBooksByAuthorRequest request);
        public int CheckAuthorCount(int input);


    }
}

