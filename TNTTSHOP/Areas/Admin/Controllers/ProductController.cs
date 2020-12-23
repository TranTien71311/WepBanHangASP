using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TNTTSHOP.Areas.Admin.Data;
using TNTTSHOP.Areas.Admin.Models;

namespace TNTTSHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly DPContext _context;

        public ProductController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index()
        {
            Random rand = new Random();
            ViewData["rand"] = rand.Next().ToString();
            var dPContext = _context.ProductModels.Include(p => p.CategoryModel);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModels
                .Include(p => p.CategoryModel)
                .FirstOrDefaultAsync(m => m.MaPro == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.CategoryModels, "MaCate", "name");
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPro,name,image,quantity,price,content,status,Category")] ProductModel productModel,IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productModel);
                await _context.SaveChangesAsync();

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", productModel.MaPro + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                productModel.image = productModel.MaPro + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                productModel.quantity = 0;

                _context.Update(productModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category"] = new SelectList(_context.CategoryModels, "MaCate", "MaCate", productModel.Category);
            return View(productModel);
        }

        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModels.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.CategoryModels, "MaCate", "name", productModel.Category);
            return View(productModel);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaPro,name,image,quantity,price,content,status,Category")] ProductModel productModel,IFormFile ful)
        {
            if (id != productModel.MaPro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(ful != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", productModel.image);
                        System.IO.File.Delete(path);

                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", productModel.MaPro + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        productModel.image = productModel.MaPro + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];

                    }    
                    _context.Update(productModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductModelExists(productModel.MaPro))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category"] = new SelectList(_context.CategoryModels, "MaCate", "MaCate", productModel.Category);
            return View(productModel);
        }

        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModels
                .Include(p => p.CategoryModel)
                .FirstOrDefaultAsync(m => m.MaPro == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productModel = await _context.ProductModels.FindAsync(id);
            _context.ProductModels.Remove(productModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductModelExists(int id)
        {
            return _context.ProductModels.Any(e => e.MaPro == id);
        }
    }
}
