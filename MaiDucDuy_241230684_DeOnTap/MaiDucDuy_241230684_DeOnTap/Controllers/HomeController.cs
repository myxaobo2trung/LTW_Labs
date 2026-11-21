using MaiDucDuy_241230684_DeOnTap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaiDucDuy_241230684_DeOnTap.Controllers
{
    public class HomeController : Controller
    {
        private readonly QltaiSanContext _context;
        public HomeController(QltaiSanContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dsTaiSan = _context.TaiSans
                .Where(t => t.NguyenGia != null && t.NguyenGia >= 20)
                .ToList();
            ViewBag.SectionTitle = "Họ tên sinh viên";

            return View(dsTaiSan);
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
        public IActionResult GetTaiSanByLoai(int maLoai)
        {
            if (maLoai == 0)
            {
                var dsMacDinh = _context.TaiSans
                    .Where(t => t.NguyenGia != null && t.NguyenGia >= 20)
                    .ToList();
                ViewBag.SectionTitle = "HỌ TÊN SINH VIÊN";
                return PartialView("MDD_MainContent", dsMacDinh);
            }

            var loai = _context.LoaiTaiSans.Find(maLoai);
            var dsTaiSan = _context.TaiSans
                .Where(t => t.MaLoai == maLoai)
                .ToList();

            ViewBag.SectionTitle = loai?.TenLoai ?? "Danh sách tài sản";
            return PartialView("MDD_MainContent", dsTaiSan);
        }
    }
}
