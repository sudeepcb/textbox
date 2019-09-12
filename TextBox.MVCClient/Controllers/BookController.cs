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
        public IActionResult Create(Book book,Author author,Genre genre)
        {

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
