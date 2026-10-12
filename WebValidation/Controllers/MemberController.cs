using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using WebValidation.Models.DataModels;

namespace WebValidation.Controllers
{
    public class MemberController : Controller
    {
        public static readonly List<Member> members = new List<Member>();

        public IActionResult Index()
        {
            return View(members);
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
