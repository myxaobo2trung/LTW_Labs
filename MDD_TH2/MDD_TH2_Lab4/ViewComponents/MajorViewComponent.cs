using Microsoft.AspNetCore.Mvc;
using MDD_TH2_Lab4.Models.Data;
using MDD_TH2_Lab4.Models;

namespace MDD_TH2_Lab4.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}

