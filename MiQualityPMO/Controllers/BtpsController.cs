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
    public class BtpsController : Controller
    {
        private readonly MiQualityPMOContext _context;

        public BtpsController(MiQualityPMOContext context)
        {
            _context = context;
        }

        // GET: Btps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Btp.ToListAsync());
        }

        // GET: Btps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btp = await _context.Btp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btp == null)
            {
                return NotFound();
            }

            return View(btp);
        }

        // GET: Btps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Btps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Factory,FiscalYear,Quarter,PorRate,MiRate")] Btp btp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(btp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(btp);
        }

        // GET: Btps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btp = await _context.Btp.FindAsync(id);
            if (btp == null)
            {
                return NotFound();
            }
            return View(btp);
        }

        // POST: Btps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Factory,FiscalYear,Quarter,PorRate,MiRate")] Btp btp)
        {
            if (id != btp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(btp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BtpExists(btp.Id))
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
            return View(btp);
        }

        // GET: Btps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btp = await _context.Btp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btp == null)
            {
                return NotFound();
            }

            return View(btp);
        }

        // POST: Btps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var btp = await _context.Btp.FindAsync(id);
            _context.Btp.Remove(btp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BtpExists(int id)
        {
            return _context.Btp.Any(e => e.Id == id);
        }
    }
}
