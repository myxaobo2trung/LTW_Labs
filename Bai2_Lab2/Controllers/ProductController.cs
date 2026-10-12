using Bai2_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bai2_Lab2.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product {id = 1, name = "Product Name 1", imgUrl = "/images/images.jpg" },
            new Product { id = 2, name = "Product Name 2", imgUrl = "/images/images.jpg" },
            new Product { id = 3, name = "Product Name 3", imgUrl = "/images/images.jpg" },
            new Product { id = 4, name = "Product Name 4", imgUrl = "/images/images.jpg"}
        };

        public IActionResult Detail(int id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
