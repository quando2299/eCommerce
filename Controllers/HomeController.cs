using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LayoutDemo.Models;
using LayoutDemo.Data;

namespace LayoutDemo.Controllers
{
    public class HomeController : Controller
    {
        DataContext dataContext;

        public HomeController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchItem(string searchname)
        {
            var product = dataContext.Products.FirstOrDefault(m => m.Name == searchname);

            return View(product);

            //return RedirectToAction("SearchItem", "Home");
        }

        public IActionResult Contact()
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
