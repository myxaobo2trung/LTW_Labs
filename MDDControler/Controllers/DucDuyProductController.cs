using MDDControler.Models;
using Microsoft.AspNetCore.Mvc;

namespace MDDControler.Controllers
{
    public class DucDuyProductController : Controller
    {
        public IActionResult Index()
        {
            //tao 1 sp
            var product = new DucDuyProduct()
            {
                productId = "P001",
                productName = "Lenovo",
                quantity = 100,
                price = 1200
            };
            ViewBag.ProductVB = product;
            ViewData["ProductVD"] = product;

          
            return View();
        }
        public IActionResult GetAllProducts()
        {
            // tao mock data
            List<DucDuyProduct> productList = new List<DucDuyProduct>
            {
                new DucDuyProduct { productId = "SP001", productName = "Laptop Dell XPS 15", quantity = 10, price = 1500.00m },
                new DucDuyProduct { productId = "SP002", productName = "Chuột không dây Logitech", quantity = 50, price = 45.50m },
                new DucDuyProduct { productId = "SP003", productName = "Bàn phím cơ Keychron", quantity = 25, price = 85.00m },
                new DucDuyProduct { productId = "SP004", productName = "Màn hình LG UltraGear 27 inch", quantity = 15, price = 350.00m },
                new DucDuyProduct { productId = "SP005", productName = "Tai nghe chống ồn Sony", quantity = 30, price = 299.99m },
                new DucDuyProduct { productId = "SP006", productName = "Ổ cứng SSD Samsung 1TB", quantity = 40, price = 110.00m },
                new DucDuyProduct { productId = "SP007", productName = "RAM Corsair 16GB", quantity = 60, price = 65.00m },
                new DucDuyProduct { productId = "SP008", productName = "Card đồ họa RTX 4070", quantity = 8, price = 650.00m },
                new DucDuyProduct { productId = "SP009", productName = "Loa Bluetooth JBL", quantity = 20, price = 120.00m },
                new DucDuyProduct { productId = "SP010", productName = "Webcam Logitech C920", quantity = 35, price = 75.00m }
            };
            // luu vao doi tuong viewbag de chuyen len view
            ViewData["products"] = productList;
            return View("Products");
        }
    }
}
