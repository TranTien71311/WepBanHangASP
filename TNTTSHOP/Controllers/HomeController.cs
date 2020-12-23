using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TNTTSHOP.Areas.Admin.Data;

namespace TNTTSHOP.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;
        public HomeController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Random rand = new Random();
            ViewData["rand"] = rand.Next().ToString();
            var dPContext = _context.ProductModels
                .Include(p => p.CategoryModel)
                .Where(p => p.status == 1)
                .OrderByDescending(p => p.MaPro);
            var Cate = _context.CategoryModels.Where(m => m.status.Equals(1));
            ViewBag.ListCate = Cate;
            return View(await dPContext.ToListAsync());
        }
    }
}
