using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            List<Author> authors = new List<Author>() { 
                new Author() { Id = 1, Name = "H.P. Lovecraft" },            
                new Author() { Id = 2, Name = "Dan Brown" },
                new Author() { Id = 3, Name = "J. R. R. Tolkien" }
            };

            List<Book> books = new List<Book>() { 
                new Book() { Id = 1, Title = "The Doom That Came to Sarnath", Author = Book.FindAuthor(authors, "H.P. Lovecraft")},
                new Book() { Id = 2, Title = "The Call of Cthulhu", Author = Book.FindAuthor(authors, "H.P. Lovecraft")},
                new Book() { Id = 3, Title = "The Lord of the Rings", Author = Book.FindAuthor(authors, "J. R. R. Tolkien")},
                new Book() { Id = 4, Title = "The Da Vinci Code", Author = Book.FindAuthor(authors, "Dan Brown")},
                new Book() { Id = 5, Title = "Inferno", Author = Book.FindAuthor(authors, "Dan Brown")}
            };

            authors.ForEach(a => a.Books.AddRange(a.FindBooks(books)));
            ViewData["authors"] = authors;
            return View();
        }
    }
}
