using Microsoft.AspNetCore.Mvc;
using WebValidation.Models.DataModels;
using WebValidation.Models.ViewModels;
namespace WebValidation.Controllers
{
    public class MembersController : Controller
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
        [HttpPost]
        public IActionResult Create(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                Member m = new Member()
                {
                    MemberId = Guid.NewGuid().ToString(),
                    UserName = register.UserName,
                    FullName = register.FullName,
                    Email = register.Email,
                    PassWord = register.Password,
                    Phone = register.Phone,
                    BirthDay = register.BirthDay,

                };
                members.Add(m);
                return RedirectToAction("Index");

            }
            else
            {
                return View(register);
            }
        }

    }
}
