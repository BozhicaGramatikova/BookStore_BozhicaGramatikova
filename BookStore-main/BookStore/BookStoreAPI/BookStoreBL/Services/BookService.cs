using BookStoreBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            if (id <= 0) return new Book();

            return _bookRepository.GetById(id);
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Remove(int id)
        {
            _bookRepository.Remove(id);
        }

        public List<Book> GetAllByAuthorAfterReleaseDate
            (int authorId, DateTime afterDate)
        {
            var result =
                _bookRepository.GetAllByAuthor(authorId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }
    }
}
