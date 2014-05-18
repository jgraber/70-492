using Authenticated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Authenticated.Controllers
{
    [Authorize]
    public class BooksController : ApiController
    {
        private static List<Book> books = new List<Book>();

        public BooksController()
        {
            if (books.Count == 0)
            {
                books.Add(new Book { Id = 1, Title = "CTOR first" });
                books.Add(new Book { Id = 2, Title = "CTOR 2nd" });
                books.Add(new Book { Id = 3, Title = "CTOR third" });
            }
        }

        // GET api/books
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET api/books/5
        public IHttpActionResult GetBook(int id)
        {
            Book book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // POST api/books
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook([FromBody]Book book)
        {
            int newId = books.Max(b => b.Id) + 1;
            book.Id = newId;
            books.Add(book);

            return CreatedAtRoute("DefaultApi", new { id = book.Id }, book);
        }

        // PUT api/books/5
        public void Put(int id, [FromBody] Book book)
        {
            book.Id = id;
            books.Add(book);
        }

        // DELETE api/books/5
        public void Delete(int id)
        {
            Book book = books.Find(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);   
            }
        }
    }
}
