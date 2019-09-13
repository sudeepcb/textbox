using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextBox.Data;
using TextBox.Domain.Models;
using TextBox.MVCClient.Models;

namespace TextBox.MVCClient.Controllers
{
    
    public class BookController : Controller
    {
        private TextBoxDBContext _db = new TextBoxDBContext();
        public IActionResult Detail()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Create(Book b,Author a,Genre g)
        {
          Author author = new Author();
          b.BookAuthors  = new List<Author>();
          b.BookGenres = new List<Genre>();

          author.FirstName = "John";
          author.LastName = "Smith";
          b.BookAuthors.Add(a);
          b.BookAuthors.Add(author);
          b.BookGenres.Add(g);

          _db.Books.Add(b);
          _db.SaveChanges();

          return View();
        }
        public IActionResult UserDetails()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
