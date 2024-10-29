using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PérezJosé_Progreso1.Data;
using PérezJosé_Progreso1.Models;

namespace PérezJosé_Progreso1.Controllers
{
    public class PerezJsController : Controller
    {
        private readonly PérezJosé_Progreso1Context _context;

        public PerezJsController(PérezJosé_Progreso1Context context)
        {
            _context = context;
        }

        // GET: PerezJs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PerezJ.ToListAsync());
        }

        // GET: PerezJs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perezJ = await _context.PerezJ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perezJ == null)
            {
                return NotFound();
            }

            return View(perezJ);
        }

        // GET: PerezJs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerezJs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AtributoInt,AtributoDecimal,AtributoString,AtributoBool,Fecha")] PerezJ perezJ)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perezJ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perezJ);
        }

        // GET: PerezJs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perezJ = await _context.PerezJ.FindAsync(id);
            if (perezJ == null)
            {
                return NotFound();
            }
            return View(perezJ);
        }

        // POST: PerezJs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AtributoInt,AtributoDecimal,AtributoString,AtributoBool,Fecha")] PerezJ perezJ)
        {
            if (id != perezJ.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perezJ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerezJExists(perezJ.Id))
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
            return View(perezJ);
        }

        // GET: PerezJs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perezJ = await _context.PerezJ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perezJ == null)
            {
                return NotFound();
            }

            return View(perezJ);
        }

        // POST: PerezJs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perezJ = await _context.PerezJ.FindAsync(id);
            if (perezJ != null)
            {
                _context.PerezJ.Remove(perezJ);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerezJExists(int id)
        {
            return _context.PerezJ.Any(e => e.Id == id);
        }
    }
}
