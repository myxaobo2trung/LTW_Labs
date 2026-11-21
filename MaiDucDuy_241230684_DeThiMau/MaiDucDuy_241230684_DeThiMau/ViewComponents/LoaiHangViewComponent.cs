using MaiDucDuy_241230684_DeThiMau.Models;
using Microsoft.AspNetCore.Mvc;
namespace MaiDucDuy_241230684_DeThiMau.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public LoaiHangViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsLoai = _context.LoaiHangs.ToList();
            return View("RenderLoaiHang", dsLoai);
        }
    }
}
