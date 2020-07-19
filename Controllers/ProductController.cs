using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayoutDemo.Data;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LayoutDemo.Controllers
{
    public class ProductController : Controller
    {
        DataContext dataContext;

        public ProductController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index(int? page)
        {

            var pageNumber = page ?? 1;
            ViewBag.products = dataContext.Products.ToList().ToPagedList(pageNumber, 8);
            return View();
        }

        public IActionResult TableTopStands()
        {
            return View();
        }
        public IActionResult PlantStands ()
        {
            return View();
        }
        public IActionResult WallPlanters()
        {
            return View();
        }
        public IActionResult Other()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}