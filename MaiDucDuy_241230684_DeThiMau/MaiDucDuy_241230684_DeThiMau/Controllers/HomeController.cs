using MaiDucDuy_241230684_DeThiMau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaiDucDuy_241230684_DeThiMau.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _context;
        public HomeController(QlhangHoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dsHang = _context.HangHoas
                 .Where(h => h.Gia != null && h.Gia >= 100)
                 .ToList();
            ViewBag.SectionTitle = "Họ tên sinh viên";
            return View(dsHang);
        }
        public IActionResult GetHangHoaByLoai(int maLoai)
        {
            if(maLoai == 0)
            {
                var dsMacDinh = _context.HangHoas
                    .Where(h => h.Gia != null && h.Gia >= 100)
                    .ToList();
                ViewBag.SectionTitle = "Họ tên sinh viên";
                return PartialView("MDD_MainContent", dsMacDinh);
            }
            var loai = _context.LoaiHangs.Find(maLoai);
            var dsHang = _context.HangHoas
                .Where(h => h.MaLoai == maLoai)
                .ToList();
            ViewBag.Sectiontitle = loai?.TenLoai ?? "New Products";
            return PartialView("MDD_MainContent", dsHang);
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
    }
}
