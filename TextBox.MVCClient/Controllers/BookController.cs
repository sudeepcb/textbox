using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextBox.Domain.Models;
using TextBox.MVCClient.Models;

namespace TextBox.MVCClient.Controllers
{
    public class BookController : Controller
    {
        BookModel b = new BookModel();
        public IActionResult Detail(int filterName)
        {
          b.returnBook(filterName);
            return View(b);
        }
        [HttpGet]
        public IActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Create(Book b,Author a,Genre g)
        {
          BookInsertion bi = new BookInsertion();
          bi.AddBookToDB(b,a,g);

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
