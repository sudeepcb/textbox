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
      int i=0;

        
        public IActionResult Home()
        {
          if(i==0)
          {l.setLists();
          i++;}
          return View(l);
          //return View(l.dbList());
        }

        [HttpPost]
        public IActionResult Home(List <Book> library, int filtertype)//, string param)
        {
            l.SortLib(library, filtertype);
            return Home();
        }
        
        [HttpGet]
        public IActionResult Home(List <Book> library, int filtertype, string param)
        {
            l.Search(library, filtertype);
            return Home();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
