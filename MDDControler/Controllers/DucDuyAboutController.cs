using Microsoft.AspNetCore.Mvc;

namespace MDDControler.Controllers
{   
    /// <summary>
    /// Name: About Mai Duc Duy
    /// Author: Mai Duc Duy
    /// </summary>
    public class DucDuyAboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Mai Duc Duy";
            ViewData["class"] = "CNTT2K65";
            TempData["mon"] = "LTW";
            return View();
        }
    }
}
