using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreModels.Models.Requests
{
    public class GetAllBooksByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime DateAfter { get; set; }
    }
}
