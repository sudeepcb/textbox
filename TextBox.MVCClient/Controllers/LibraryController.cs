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
      System.Console.WriteLine("\n\n\n\n\n True Home \n\n\n\n\n");
      
      l.setLists();
      return View(l);
    }

    public IActionResult Home(int filtertype)
    {
      System.Console.WriteLine("\n\n\n\n\n Home just filtertype \n\n\n\n\n");
      
      l.setLists();
      l.SortLib(filtertype);
      return View(l);
    }
    
    public IActionResult Sort(string filterName, int index)
    {
      System.Console.WriteLine("\n\n\n\n\n Sort \n\n\n\n\n");
      l.Home(filterName, index);
      return View(l);
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
