using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TNTTSHOP.Areas.Admin.Data;
using TNTTSHOP.Areas.Admin.Models;
using TNTTSHOP.Helpers;

namespace TNTTSHOP.Controllers
{
    public class CartController : Controller
    {
        private readonly DPContext _context;
        public CartController(DPContext context)
        {
            _context = context;
        }
        public List<CartItem>Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if(data==null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }
        public IActionResult Index()
        {
            Random rand = new Random();
            ViewData["rand"] = rand.Next().ToString();
            return View(Carts);
        }
        public IActionResult AddtoCart(int id,int quantity, int total, string type="Normal")
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Ma == id);
            if(item==null)
            {
                var Product = _context.ProductModels.SingleOrDefault(p => p.MaPro == id);
                item = new CartItem
                {
                    Ma=id,
                    name=Product.name,
                    DonGia=Product.price,
                    quantity=1,
                    image=Product.image,
                };
                myCart.Add(item);
            }
            else
            {
                item.quantity++;
            }
            HttpContext.Session.Set("GioHang",myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    quantity = Carts.Sum(q => q.quantity),
                    total=Carts.Sum(t=>t.thanhtien).ToString("N0")
                });
            }
            return RedirectToAction("Index");
        }
    }
}
