﻿using BookstoreDL.Interfaces;
using BookstoreDL.MemoryDB;
using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreDL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return InMemoryDb.BookData;
        }

        public Book GetById(int id)
        {
            return InMemoryDb.BookData
                .First(a => a.Id == id);
        }

        public void Add(Book author)
        {
            InMemoryDb.BookData.Add(author);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.BookData.Remove(author);
        }

        public List<Book> GetAllByAuthor(int authorId)
        {
            return InMemoryDb.BookData
                .Where(b => b.AuthorId == authorId)
                .ToList();
        }
    }
}
