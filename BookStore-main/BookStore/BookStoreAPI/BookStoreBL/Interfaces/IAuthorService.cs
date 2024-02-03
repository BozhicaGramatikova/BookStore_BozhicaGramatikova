using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        Author GetbyId(int id);

        void Add(Author author);

        void Delete(int id);
    }
}
   
