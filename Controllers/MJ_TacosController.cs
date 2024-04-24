using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MJPruebaProgreso1.Data;
using MJPruebaProgreso1.Models;

namespace MJPruebaProgreso1.Controllers
{
    public class MJ_TacosController : Controller
    {
        private readonly MJPruebaProgreso1Context _context;

        public MJ_TacosController(MJPruebaProgreso1Context context)
        {
            _context = context;
        }

        // GET: MJ_Tacos
        public async Task<IActionResult> MJCrearTaco()
        {
            return View(await _context.MJ_Tacos.ToListAsync());
        }

        // GET: MJ_Tacos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mJ_Tacos = await _context.MJ_Tacos
                .FirstOrDefaultAsync(m => m.TacoID == id);
            if (mJ_Tacos == null)
            {
                return NotFound();
            }

            return View(mJ_Tacos);
        }

        // GET: MJ_Tacos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MJ_Tacos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TacoID,MJ_NombreTaco,MJ_DescripcionDelTaco,MJ_PrecioTaco,MJ_Fecha,MJ_Guacamole")] MJ_Tacos mJ_Tacos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mJ_Tacos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MJCrearTaco));
            }
            return View(mJ_Tacos);
        }

        // GET: MJ_Tacos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mJ_Tacos = await _context.MJ_Tacos.FindAsync(id);
            if (mJ_Tacos == null)
            {
                return NotFound();
            }
            return View(mJ_Tacos);
        }

        // POST: MJ_Tacos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TacoID,MJ_NombreTaco,MJ_DescripcionDelTaco,MJ_PrecioTaco,MJ_Fecha,MJ_Guacamole")] MJ_Tacos mJ_Tacos)
        {
            if (id != mJ_Tacos.TacoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mJ_Tacos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MJ_TacosExists(mJ_Tacos.TacoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MJCrearTaco));
            }
            return View(mJ_Tacos);
        }

        // GET: MJ_Tacos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mJ_Tacos = await _context.MJ_Tacos
                .FirstOrDefaultAsync(m => m.TacoID == id);
            if (mJ_Tacos == null)
            {
                return NotFound();
            }

            return View(mJ_Tacos);
        }

        // POST: MJ_Tacos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mJ_Tacos = await _context.MJ_Tacos.FindAsync(id);
            if (mJ_Tacos != null)
            {
                _context.MJ_Tacos.Remove(mJ_Tacos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MJCrearTaco));
        }

        private bool MJ_TacosExists(int id)
        {
            return _context.MJ_Tacos.Any(e => e.TacoID == id);
        }
    }
}
