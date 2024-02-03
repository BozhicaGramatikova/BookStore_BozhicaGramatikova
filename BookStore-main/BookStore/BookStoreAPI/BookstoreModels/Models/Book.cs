using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreModels.Models
{
    public class Book
    {
        public string Title;

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int AuthorId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
