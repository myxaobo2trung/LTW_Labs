using MaiDucDuy_241230684_DeOnTap.Models;
using Microsoft.AspNetCore.Mvc;
namespace MaiDucDuy_241230684_DeOnTap.ViewComponents
{
    public class LoaiTaiSanViewComponent : ViewComponent
    {
        private readonly QltaiSanContext _context;
        public LoaiTaiSanViewComponent(QltaiSanContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsLoai = _context.LoaiTaiSans.ToList();
            return View("RenderLoaiTaiSan", dsLoai);
        }
    }
}
