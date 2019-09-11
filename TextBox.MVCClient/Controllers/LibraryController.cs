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
    public class LibraryController : Controller
    {

      LibraryModel l = new LibraryModel();
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult displayLibrary(List<Book> library)
        {
            return View(library);
        }

        [HttpPost]
        public IActionResult SortCat(int i, List <Book> library)
        {
            return displayLibrary(l.SortLib(i,library));
        }
        
        [HttpPost]
        public IActionResult SearchPar(int i, List <Book> library)
        {
            return displayLibrary(l.SearchAuthor(i,library));
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
