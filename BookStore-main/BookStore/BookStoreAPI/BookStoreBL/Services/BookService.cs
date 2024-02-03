using BookStoreBL.Interfaces;
using BookstoreDL.Interfaces;
using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Services
{

        public class BookService : IBookService
        {

            private readonly IBookRepository _bookRepository;

            public BookService(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public void Add(Book book)
            {
                _bookRepository.Add(book);
            }

            public void Remove(int id)
            {
                _bookRepository.Remove(id);
            }


            public List<Book> GetAll()
            {
                return _bookRepository.GetAll();
            }

            public List<Book> GetAllByAuthorAfterReleaseDate(int authorId, DateTime afterDate)
            {
                throw new NotImplementedException();
            }

            public List<Book> GetAllByAuthorId(int authorId)
            {
                return _bookRepository.GetAllByAuthor(authorId);
            }

            public Book? GetById(int id)
            {
                return _bookRepository.GetById(id);
            }

        
        }
    }

