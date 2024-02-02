using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreModels.Models.Response
{
    public class GetAllBooksByAuthorResponse
    {
        public Author? Author { get; set; }

        public List<Book>? Books { get; set; }
    }
}
