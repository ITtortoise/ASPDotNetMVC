using Autofac.Extras.Moq;
using Library.Framework.BookRepositories;
using Library.Framework.BookServices;
using Library.Framework.Entity;
using Library.Framework.LUnitOfWork;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;

namespace Library.Framework.Tests
{
    [ExcludeFromCodeCoverage]
    
    public class BookServiceTests
    {
        private AutoMock _mock;
        private Mock<IBookRepository> _bookRepositorymock;
        private Mock<ILibraryUnitOfWork> _libraryUnitOfWorkmock;
        private IBookService _bookService;

        [OneTimeSetUp]
        public void ClassSetUp()
        {
            _mock = AutoMock.GetLoose();
        }
        [OneTimeTearDown]
        public void ClassCleanUp()
        {
            _mock?.Dispose();
        }
        [SetUp]
        public void Setup()
        {
            _libraryUnitOfWorkmock = _mock.Mock<ILibraryUnitOfWork>();
            _bookRepositorymock = _mock.Mock<IBookRepository>();
            _bookService = _mock.Create<BookService>();
        }
        [TearDown]
        public void Clean()
        {
            _libraryUnitOfWorkmock.Reset();
            _bookRepositorymock.Reset();
        }

        [Test]
        public void CreateBook_BookAlReadyExists_ThrowsException()
        {
            //Arrange 
            var book = new Book
            {
                Id = 1,
                Author = "Jhon",
                Edition = "1st",
                PublicationDate = DateTime.Now,
                Title = "Test Book"

            };
            var bookTomatch = new Book
            {
                Title = "Test Book"
            };
            _libraryUnitOfWorkmock.Setup(x => x.BookRepositroy)
                .Returns(_bookRepositorymock.Object);

            _bookRepositorymock.Setup(x => x.GetCount(
                It.Is<Expression<Func<Book, bool>>>(y => y.Compile()(bookTomatch))))
                .Returns(1).Verifiable();

            //Act
            Should.Throw<DuplicationException>(() =>
            _bookService.CreateBook(book)
            );

            //Assert
            _bookRepositorymock.VerifyAll();
        }

    }

}
