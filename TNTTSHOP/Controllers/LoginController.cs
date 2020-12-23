using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TNTTSHOP.Areas.Admin.Data;
using TNTTSHOP.Areas.Admin.Models;

namespace TNTTSHOP.Controllers
{
    public class LoginController : Controller
    {
        private readonly DPContext _context;
        public LoginController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login([Bind("email", "password")] UserModel user)
        {
            var r = _context.UserModels.Where(m => (m.email == user.email && m.password == StringProcessing.CreateMD5Hash(user.password))).ToList();
            if (r.Count == 0)
            {
                return View("Index");
            }
            var str = JsonConvert.SerializeObject(user);
            HttpContext.Session.SetString("user", str);
            if (r[0].position.Equals("0"))
            {
                var url = Url.RouteUrl("areas", new { controller = "Home", action = "Index", area = "Admin" });
                return Redirect(url);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
