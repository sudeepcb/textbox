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
      
      
    [HttpGet]
    public IActionResult Home()
    {
      l.setLists();
      return View(l);
    }

    public void Home(string filterName, int index)
    {
      System.Console.WriteLine("\n\n\n\n\n Things are going well \n\n\n\n\n");
      l.setSearchLists();
      l.SearchLib(filterName,index);
      foreach (var a in l.library)
      {System.Console.WriteLine("\n\n\n\n\n "+a.Title+" \n\n\n\n\n");}
      System.Console.WriteLine("\n\n\n\n\n going to view \n\n\n\n\n");
    }

    [HttpPost]
    public IActionResult Home(int filtertype)//, List<Book> name, string param)
    {
      l.setLists();
      l.SortLib(filtertype);
      return View(l);
    }
    
    public IActionResult Sort(string filterName, int index)//, List<Book> library)
    {
      Home(filterName, index);
      return View(l);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
