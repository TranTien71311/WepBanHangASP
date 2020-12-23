using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TNTTSHOP.Areas.Admin.Data;
using TNTTSHOP.Areas.Admin.Models;

namespace TNTTSHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SupplientController : Controller
    {
        private readonly DPContext _context;

        public SupplientController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Supplient
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupplientModel.ToListAsync());
        }

        // GET: Admin/Supplient/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplientModel = await _context.SupplientModel
                .FirstOrDefaultAsync(m => m.MaSupp == id);
            if (supplientModel == null)
            {
                return NotFound();
            }

            return View(supplientModel);
        }

        // GET: Admin/Supplient/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Supplient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSupp,name,Email,address,status")] SupplientModel supplientModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplientModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplientModel);
        }

        // GET: Admin/Supplient/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplientModel = await _context.SupplientModel.FindAsync(id);
            if (supplientModel == null)
            {
                return NotFound();
            }
            return View(supplientModel);
        }

        // POST: Admin/Supplient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSupp,name,Email,address,status")] SupplientModel supplientModel)
        {
            if (id != supplientModel.MaSupp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplientModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplientModelExists(supplientModel.MaSupp))
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
            return View(supplientModel);
        }

        // GET: Admin/Supplient/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplientModel = await _context.SupplientModel
                .FirstOrDefaultAsync(m => m.MaSupp == id);
            if (supplientModel == null)
            {
                return NotFound();
            }

            return View(supplientModel);
        }

        // POST: Admin/Supplient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplientModel = await _context.SupplientModel.FindAsync(id);
            _context.SupplientModel.Remove(supplientModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplientModelExists(int id)
        {
            return _context.SupplientModel.Any(e => e.MaSupp == id);
        }
    }
}
