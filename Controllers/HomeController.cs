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
        readonly DataContext dataContext;

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
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
