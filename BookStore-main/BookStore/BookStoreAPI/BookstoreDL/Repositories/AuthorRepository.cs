using BookstoreDL.Interfaces;
using BookstoreDL.MemoryDB;
using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreDL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorsData;
        }

        public Author GetById(int id)
        {
            return InMemoryDb.AuthorsData
                .First(a => a.Id == id);
        }

        public void Add(Author author)
        {
            InMemoryDb.AuthorsData.Add(author);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.AuthorsData.Remove(author);
        }

        public Author GetbyId(int id)
        {
            throw new NotImplementedException();
        }
    }

}