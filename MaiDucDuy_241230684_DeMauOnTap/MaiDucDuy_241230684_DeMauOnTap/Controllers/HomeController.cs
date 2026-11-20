using MaiDucDuy_241230684_DeMauOnTap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace MaiDucDuy_241230684_DeMauOnTap.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlnhaSachContext _context;
        public HomeController(QlnhaSachContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dsSach = _context.Saches
                .Where(s => s.Gia != null && s.Gia >= 1000)
                .ToList();
            ViewBag.SectionTitle = "Họ tên sinh viên";
            return View(dsSach);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GetSachByTheLoai(int maTL)
        {
            if(maTL == 0)
            {
                var dsMacDinh = _context.Saches
                    .Where(s => s.Gia != null && s.Gia >= 100)
                    .ToList();
                ViewBag.SectionTitle = "Họ tên sinh viên";
                return PartialView("MDD_MainContent", dsMacDinh);
            }
            var theLoai = _context.TheLoais.Find(maTL);
            var dsSach = _context.Saches
                .Where(s => s.MaTl == maTL)
                .ToList();
            ViewBag.SectionTitle = theLoai?.TenTl ?? "Danh sách sách";
            return PartialView("MDD_MainContent", dsSach);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaTl = new SelectList(_context.TheLoais.ToList(), "MaTl", "TenTl");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sach sach)
        {
            if (ModelState.IsValid)
            {
                _context.Saches.Add(sach);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
              
            }
            ViewBag.MaTl = new SelectList(_context.TheLoais.ToList(), "MaTl", "TenTl", sach.MaTl);
            return View(sach);
        }
    }
}
