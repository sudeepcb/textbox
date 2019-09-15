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
      static int i=0;

        
        public IActionResult Home()
        {
          l.setLists();
          return View(l);
        }

        [HttpPost]
        public IActionResult Home(LibraryModel m, int filtertype, List<Book> name)//, string param)
        {
          System.Console.WriteLine("\n\n\n\n\n"+filtertype+"\n\n\n\n\n");
          // foreach ( var b in m.library.ToList())
          // {
          //   System.Console.WriteLine("\n\n\n\n\n"+b.Title+"\n\n\n\n\n");
          // }
          l.setLists();
          l.SortLib(filtertype);
          return View(l);
        }
        
        public IActionResult Sort(LibraryModel m, string param)//string Genrename, string Fname, string seriesName)//, List<Book> library)
        {
          l.setLists();
          l.SearchLib(param);
          return View(l);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
