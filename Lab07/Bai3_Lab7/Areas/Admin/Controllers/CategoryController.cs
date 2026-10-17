using Microsoft.AspNetCore.Mvc;

namespace Bai3_Lab7.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")]   
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
