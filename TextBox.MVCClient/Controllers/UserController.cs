using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextBox.MVCClient.Models;

namespace TextBox.MVCClient.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult OrderHistory()
        {
            return View();
        }
        public IActionResult Recommended()
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
