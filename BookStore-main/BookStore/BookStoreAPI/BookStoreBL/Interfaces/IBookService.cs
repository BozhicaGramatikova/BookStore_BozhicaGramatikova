using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Remove(int id);

        public List<Book>
            GetAllByAuthorAfterReleaseDate(
                int authorId,
                DateTime afterDate);
    }
}
