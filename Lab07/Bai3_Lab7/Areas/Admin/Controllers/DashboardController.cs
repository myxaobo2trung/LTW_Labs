using Microsoft.AspNetCore.Mvc;

namespace Bai3_Lab7.Areas.Admins.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
