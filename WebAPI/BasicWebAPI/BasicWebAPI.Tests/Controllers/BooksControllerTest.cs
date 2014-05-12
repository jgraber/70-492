using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicWebAPI.Controllers;
using BasicWebAPI.App_Start;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Results;

namespace BasicWebAPI.Tests.Controllers
{
    
    [TestClass]
    public class BooksControllerTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB"));
        }
        
        [TestMethod]
        public void PostBook()
        {
            // Arrange
            BooksController controller = new BooksController();
            var book = new Book() { Title = "Hello Test", ISBN = "12234", Pages = 3 };

            // Act
            var result = (CreatedAtRouteNegotiatedContentResult<Book>)controller.PostBook(book);

            
            // Assert
            Assert.AreEqual(result.Content.ISBN, "12234");
            Assert.AreEqual(result.Content.Title, "Hello Test");
            Assert.AreEqual(result.Content.Pages, 3);

        }
    }
}
