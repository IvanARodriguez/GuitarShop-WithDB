using GuitarShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuitarShop.Controllers
{

    public class CartController : Controller
    {
        private readonly ShopContext _context;

        public CartController(ShopContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            ViewBag.Total = Cart.TotalPrice();
            ViewBag.TotalWithoutDiscount = Cart.TotalWithoutDiscount();
            return View(Cart.products);
        }

        public IActionResult Add(string slug, int id)
        {
            ViewBag.ProductSlug = slug;
            Product product = _context.Products.Find(id);
            Cart.products.Add(product);
            return View();
        }

    }
}
