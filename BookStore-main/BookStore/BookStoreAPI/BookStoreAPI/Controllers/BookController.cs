﻿using BookStoreBL.Interfaces;
using BookstoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public List<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book)
        {
            _bookService.Add(book);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }
    }
}
