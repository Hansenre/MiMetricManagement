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
    public class MqaasController : Controller
    {
        private readonly MiQualityPMOContext _context;

        public MqaasController(MiQualityPMOContext context)
        {
            _context = context;
        }

        // GET: Mqaas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mqaa.ToListAsync());
        }

        // GET: Mqaas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mqaa = await _context.Mqaa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mqaa == null)
            {
                return NotFound();
            }

            return View(mqaa);
        }

        // GET: Mqaas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mqaas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Factory,FiscalYear,Quarter,PorRate,MiRate")] Mqaa mqaa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mqaa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mqaa);
        }

        // GET: Mqaas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mqaa = await _context.Mqaa.FindAsync(id);
            if (mqaa == null)
            {
                return NotFound();
            }
            return View(mqaa);
        }

        // POST: Mqaas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Factory,FiscalYear,Quarter,PorRate,MiRate")] Mqaa mqaa)
        {
            if (id != mqaa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mqaa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MqaaExists(mqaa.Id))
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
            return View(mqaa);
        }

        // GET: Mqaas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mqaa = await _context.Mqaa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mqaa == null)
            {
                return NotFound();
            }

            return View(mqaa);
        }

        // POST: Mqaas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mqaa = await _context.Mqaa.FindAsync(id);
            _context.Mqaa.Remove(mqaa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MqaaExists(int id)
        {
            return _context.Mqaa.Any(e => e.Id == id);
        }
    }
}
