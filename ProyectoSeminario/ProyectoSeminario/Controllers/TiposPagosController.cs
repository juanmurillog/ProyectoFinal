using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Definitivo.Models.Basedb;
using ProyectoSeminario.Data;

namespace ProyectoSeminario.Controllers
{
    public class TiposPagosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposPagosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposPagos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPago.ToListAsync());
        }

        // GET: TiposPagos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPago = await _context.TipoPago
                .FirstOrDefaultAsync(m => m.TipoPagoId == id);
            if (tipoPago == null)
            {
                return NotFound();
            }

            return View(tipoPago);
        }

        // GET: TiposPagos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposPagos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoPagoId,NombreTipoPago")] TipoPago tipoPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPago);
        }

        // GET: TiposPagos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPago = await _context.TipoPago.FindAsync(id);
            if (tipoPago == null)
            {
                return NotFound();
            }
            return View(tipoPago);
        }

        // POST: TiposPagos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoPagoId,NombreTipoPago")] TipoPago tipoPago)
        {
            if (id != tipoPago.TipoPagoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPagoExists(tipoPago.TipoPagoId))
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
            return View(tipoPago);
        }

        // GET: TiposPagos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPago = await _context.TipoPago
                .FirstOrDefaultAsync(m => m.TipoPagoId == id);
            if (tipoPago == null)
            {
                return NotFound();
            }

            return View(tipoPago);
        }

        // POST: TiposPagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPago = await _context.TipoPago.FindAsync(id);
            _context.TipoPago.Remove(tipoPago);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPagoExists(int id)
        {
            return _context.TipoPago.Any(e => e.TipoPagoId == id);
        }
    }
}
