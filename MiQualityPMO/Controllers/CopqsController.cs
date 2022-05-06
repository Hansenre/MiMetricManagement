using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiQualityPMO.Data;
using MiQualityPMO.Models;

namespace MiQualityPMO.Controllers
{
    public class CopqsController : Controller
    {
        private readonly MiQualityPMOContext _context;

        public CopqsController(MiQualityPMOContext context)
        {
            _context = context;
        }

        // GET: Copqs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Copq.ToListAsync());
        }

        // GET: Copqs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var copq = await _context.Copq
                .FirstOrDefaultAsync(m => m.Id == id);
            if (copq == null)
            {
                return NotFound();
            }

            return View(copq);
        }

        // GET: Copqs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Copqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Factory,FiscalYear,Quarter,WholeSalePrice,WeightedCost,MiRate")] Copq copq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(copq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(copq);
        }

        // GET: Copqs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var copq = await _context.Copq.FindAsync(id);
            if (copq == null)
            {
                return NotFound();
            }
            return View(copq);
        }

        // POST: Copqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Factory,FiscalYear,Quarter,WholeSalePrice,WeightedCost,MiRate")] Copq copq)
        {
            if (id != copq.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(copq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CopqExists(copq.Id))
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
            return View(copq);
        }

        // GET: Copqs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var copq = await _context.Copq
                .FirstOrDefaultAsync(m => m.Id == id);
            if (copq == null)
            {
                return NotFound();
            }

            return View(copq);
        }

        // POST: Copqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var copq = await _context.Copq.FindAsync(id);
            _context.Copq.Remove(copq);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CopqExists(int id)
        {
            return _context.Copq.Any(e => e.Id == id);
        }
    }
}
