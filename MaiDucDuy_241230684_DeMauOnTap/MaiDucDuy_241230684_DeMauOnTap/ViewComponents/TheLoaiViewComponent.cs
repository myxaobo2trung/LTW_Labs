using MaiDucDuy_241230684_DeMauOnTap.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaiDucDuy_241230684_DeMauOnTap.ViewComponents
{
    public class TheLoaiViewComponent : ViewComponent
    {
        private readonly QlnhaSachContext _context;
        public TheLoaiViewComponent(QlnhaSachContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsTheLoai = _context.TheLoais.ToList();
            return View("RenderTheLoai", dsTheLoai);
        }

    }
}
