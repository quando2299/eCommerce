using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LayoutDemo.Data;
using Microsoft.AspNetCore.Http;
using LayoutDemo.Models;


namespace LayoutDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext dataContext;

        public AccountController (DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users user)
        {
            var temp = dataContext.Users.FirstOrDefault(m => m.Email == user.Email);

            if (temp != null)
            {
                if (temp.Password == user.Password)
                {
                    HttpContext.Session.SetInt32("ID", temp.ID);
                    HttpContext.Session.SetString("Email", temp.Email);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users user)
        {
            var p = dataContext.Users.FirstOrDefault(p => p.Email == user.Email);
            if (p == null)
            {
                if (user.Password == user.ConfirmPassword)
                {
                    user.CreateDate = DateTime.Now;
                    user.Status = 1;
                    user.CreateUser = user.FirstName + " " + user.LastName;
                    user.EditDate = DateTime.Now;
                    user.EditUser = user.FirstName + " " + user.LastName;
                    dataContext.Users.Add(user);
                    dataContext.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }

                ViewBag.Error = "Password and Confirm Password do not match";
            }
            ViewBag.Error = "User already existed";

            return View(user);
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("UserID");
            HttpContext.Session.Remove("Email");
            return RedirectToAction("Index", "Home");
        }

    }
}
