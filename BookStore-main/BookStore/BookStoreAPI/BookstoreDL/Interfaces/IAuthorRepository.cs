using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreDL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author GetbyId(int id);

        void Add(Author author);

        void Remove(int id);
    }
}
