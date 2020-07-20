using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LayoutDemo.HelperSession;
using LayoutDemo.Models.ViewModel;
using LayoutDemo.Data;
using LayoutDemo.Models;

namespace LayoutDemo.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext db;
        public CartController(DataContext data)
        {
            this.db = data;
        }

        public IActionResult Index()
        {
            var list = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            return View(list);
        }

        public ActionResult Payment()
        {
            var list = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");

            return View(list); 
        }

        [HttpPost]
        public ActionResult ConfirmPayment(Addresses addtress)
        {


            return RedirectToAction("Index", "Home");
        }

        public ActionResult Buy(int id)
        {
            var product = db.Products.FirstOrDefault(m => m.ID == id);

            if (SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart") == null)
            {
                List<Cart> cart = new List<Cart>();
                Cart item = new Cart
                {
                    ID = product.ID,
                    Name = product.Name,
                    Image = product.Image,
                    Quantity = 1,
                    Price = product.Price,
                };
                cart.Add(item);

                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

                return RedirectToAction("Index", "Product");
            }
            else
            {
                List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
                if (GetIndex(id) != -1)
                {
                    cart[GetIndex(id)].Quantity += 1;
                }
                else
                {
                    Cart item = new Cart
                    {
                        ID = product.ID,
                        Name = product.Name,
                        Image = product.Image,
                        Quantity = 1,
                        Price = product.Price,
                    };
                    cart.Add(item);
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult BuyNow(int id)
        {
            var product = db.Products.FirstOrDefault(m => m.ID == id);
            
            if (SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart") == null)
            {
                List<Cart> cart = new List<Cart>();
                Cart item = new Cart
                {
                    ID = product.ID,
                    Name = product.Name,
                    Image = product.Image,
                    Quantity = 1,
                    Price = product.Price,
                };
                cart.Add(item);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

                return RedirectToAction("Payment");
            }
            else
            {
                List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
                if (GetIndex(id) != -1)
                {
                    cart[GetIndex(id)].Quantity += 1; 
                }
                else
                {
                    Cart item = new Cart
                    {
                        ID = product.ID,
                        Name = product.Name,
                        Image = product.Image,
                        Quantity = 1,
                        Price = product.Price,
                    };
                    cart.Add(item);
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                return RedirectToAction("Payment");
            }


            //return View();
        }

        public ActionResult Remove(int id)
        {
            List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            int index = GetIndex(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        
        public int GetIndex(int id)
        {
            List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}