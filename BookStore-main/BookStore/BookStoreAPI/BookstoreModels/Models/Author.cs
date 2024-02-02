using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreModels.Models
{
    public class Author
    {
        public Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public DateTime BirthDay { get; set; }
}
}
