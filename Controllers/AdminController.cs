using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSiteProje.Models;

namespace WebSiteProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly VeriContext _context;

        public AdminController(VeriContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Site.ToListAsync());
        }

        public async Task<IActionResult> Admin()
        {
            return View(await _context.Site.ToListAsync());
        }


        // GET: Sites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MyId,isim,meslek,profileFotoUrl,backFotoUrl,hakkımda,dogumTarihi,dogumYeri,egitimDurumu,egitimBolumu,diller,adres,adresUrl,email,emailUrl,sliderFotoUrl,sliderFotoBaslik,sliderFotoAciklama")] Site site)
        {
            if (ModelState.IsValid)
            {
                _context.Add(site);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Admin));
            }
            return View(site);
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site
                .FirstOrDefaultAsync(m => m.MyId == id);
            if (site == null)
            {
                return NotFound();
            }

            return View(site);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site.FindAsync(id);
            if (site == null)
            {
                return NotFound();
            }
            return View(site);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MyId,isim,meslek,profileFotoUrl,backFotoUrl,hakkımda,dogumTarihi,dogumYeri,egitimDurumu,egitimBolumu,diller,adres,adresUrl,email,emailUrl,sliderFotoUrl,sliderFotoBaslik,sliderFotoAciklama")] Site site)
        {
            if (id != site.MyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(site);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteExists(site.MyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Admin));
            }
            return View(site);
        }

        // GET: Sites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site
                .FirstOrDefaultAsync(m => m.MyId == id);
            if (site == null)
            {
                return NotFound();
            }

            return View(site);
        }

        // POST: Sites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var site = await _context.Site.FindAsync(id);
            _context.Site.Remove(site);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }
        private bool SiteExists(int id)
        {
            return _context.Site.Any(e => e.MyId == id);
        }
    }
}
