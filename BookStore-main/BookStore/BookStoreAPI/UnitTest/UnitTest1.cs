
using BookStoreBL.Services;
using BookstoreDL.Interfaces;
using BookstoreDL.Repositories;
using BookstoreModels.Models;
using Moq;

namespace UnitTest
{
    
    public class LibraryServiceTests


    {
        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 01,
                Name = "Book 1",
                AuthorId = 2
            },
            new Book()
            {
                Id = 02,
                Name = "Book 2",
                AuthorId = 3
            }
        };

        public static List<Author> AuthorData = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Author 1",
                BirthDay = DateTime.Now
            },
              new Author()
            {
                Id = 2,
                Name = "Author 2",
                BirthDay = DateTime.Now
            },
                new Author()
            {
                Id = 3,
                Name = "Author 3",
                BirthDay = DateTime.Now
            }
        };
       
        public void CheckBookCount_OK()
        {
            //setup 
            var input = 10;
            var expectedCount = 12;

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(
                x => x.GetAll())
                .Returns(BookData);
            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //Act
            var result = service.CheckAuthorCount(input);


            //Assert

            Assert.Equal(expectedCount, result);



        }

        public void CheckAuthorCount_Negative()
        {
            //setup 
            var input = 10;
            var expectedCount = 13;

            var mockedAuthorRepository = new Mock<IAuthorRepository>();

            mockedAuthorRepository.Setup(
                x => x.GetAll())
                .Returns(AuthorData);
            //inject
            var bookService = new BookService(new BookRepository());
            var authorService = new AuthorService(mockedAuthorRepository.Object);
            var service = new LibraryService(authorService, bookService);

            //Act
            var result = service.CheckAuthorCount(input);


            //Assert

            Assert.Equal(expectedCount, result);



        }
    }
}
