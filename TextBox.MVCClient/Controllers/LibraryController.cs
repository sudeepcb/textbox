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
        public IActionResult Home(List<Book> library)
        {
            return View(library);
        }

        [HttpPost]
        public IActionResult SortCat(List <Book> library, int i, string param)
        {
            return Home(l.Sort(library, i));
        }
        
        [HttpPost]
        public IActionResult SearchPar(List <Book> library, int i, string param)
        {
            return Home(l.Search(library, i));
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
