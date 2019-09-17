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
    public class CartController : Controller
    {
        CartModel c = new CartModel();
        public IActionResult Cart(int filterName)
        {
          System.Console.WriteLine("\n\n\n\n\n"+filterName+"\n\n\n\n\n");
          c.bookToCart(filterName);
            return View(c);
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
