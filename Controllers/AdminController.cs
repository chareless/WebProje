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

        public IActionResult Admin()
        {
            var site = _context.Site.ToList();
            var okul = _context.Okul.ToList();
            var slider = _context.SliderFoto.ToList();
            var sosyal = _context.Sosyal.ToList();
            var Class = new Alldata();
            Class.Site = site;
            Class.Okul = okul;
            Class.SliderFoto = slider;
            Class.Sosyal = sosyal;
            return View(Class);
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


        //OKUL BİLGİLERİ


        public IActionResult OkulCreate()
        {
            return View();
        }

        // POST: Okuls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OkulCreate([Bind("okulId,okulAd,okulTarih,okulTur,okulInfo")] Okul okul)
        {
            if (ModelState.IsValid)
            {
                _context.Add(okul);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Admin));
            }
            return View(okul);
        }
        // GET: Okuls/Details/5
        public async Task<IActionResult> OkulDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var okul = await _context.Okul
                .FirstOrDefaultAsync(m => m.okulId == id);
            if (okul == null)
            {
                return NotFound();
            }

            return View(okul);
        }

        // GET: Okuls/Create


        // GET: Okuls/Edit/5
        public async Task<IActionResult> OkulEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var okul = await _context.Okul.FindAsync(id);
            if (okul == null)
            {
                return NotFound();
            }
            return View(okul);
        }

        // POST: Okuls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OkulEdit(int id, [Bind("okulId,okulAd,okulTarih,okulTur,okulInfo")] Okul okul)
        {
            if (id != okul.okulId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(okul);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OkulExists(okul.okulId))
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
            return View(okul);
        }

        // GET: Okuls/Delete/5
        public async Task<IActionResult> OkulDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var okul = await _context.Okul
                .FirstOrDefaultAsync(m => m.okulId == id);
            if (okul == null)
            {
                return NotFound();
            }

            return View(okul);
        }

        // POST: Okuls/Delete/5
        [HttpPost, ActionName("OkulDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OkulDeleteConfirmed(int id)
        {
            var okul = await _context.Okul.FindAsync(id);
            _context.Okul.Remove(okul);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }

        private bool OkulExists(int id)
        {
            return _context.Okul.Any(e => e.okulId == id);
        }


        //SOSYAL MEDYA BİLGİLERİ



        // GET: Sosyals/Details/5
        public async Task<IActionResult> SosyalDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sosyal = await _context.Sosyal
                .FirstOrDefaultAsync(m => m.sosyalId == id);
            if (sosyal == null)
            {
                return NotFound();
            }

            return View(sosyal);
        }

        // GET: Sosyals/Create
        public IActionResult SosyalCreate()
        {
            return View();
        }

        // POST: Sosyals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SosyalCreate([Bind("sosyalId,sosyalUrl,sosyalTur,sosyalInfo,sosyalFooter")] Sosyal sosyal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sosyal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Admin));
            }
            return View(sosyal);
        }

        // GET: Sosyals/Edit/5
        public async Task<IActionResult> SosyalEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sosyal = await _context.Sosyal.FindAsync(id);
            if (sosyal == null)
            {
                return NotFound();
            }
            return View(sosyal);
        }

        // POST: Sosyals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SosyalEdit(int id, [Bind("sosyalId,sosyalUrl,sosyalTur,sosyalInfo,sosyalFooter")] Sosyal sosyal)
        {
            if (id != sosyal.sosyalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sosyal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SosyalExists(sosyal.sosyalId))
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
            return View(sosyal);
        }

        // GET: Sosyals/Delete/5
        public async Task<IActionResult> SosyalDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sosyal = await _context.Sosyal
                .FirstOrDefaultAsync(m => m.sosyalId == id);
            if (sosyal == null)
            {
                return NotFound();
            }

            return View(sosyal);
        }

        // POST: Sosyals/Delete/5
        [HttpPost, ActionName("SosyalDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SosyalDeleteConfirmed(int id)
        {
            var sosyal = await _context.Sosyal.FindAsync(id);
            _context.Sosyal.Remove(sosyal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }

        private bool SosyalExists(int id)
        {
            return _context.Sosyal.Any(e => e.sosyalId == id);
        }

        //SLİDER BİLGİLERİ



        // GET: SliderFotoes/Details/5
        public async Task<IActionResult> SliderDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderFoto = await _context.SliderFoto
                .FirstOrDefaultAsync(m => m.sliderFotoId == id);
            if (sliderFoto == null)
            {
                return NotFound();
            }

            return View(sliderFoto);
        }

        // GET: SliderFotoes/Create
        public IActionResult SliderCreate()
        {
            return View();
        }

        // POST: SliderFotoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SliderCreate([Bind("sliderFotoId,fotoUrl,fotoBaslik,fotoAciklama")] SliderFoto sliderFoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sliderFoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Admin));
            }
            return View(sliderFoto);
        }

        // GET: SliderFotoes/Edit/5
        public async Task<IActionResult> SliderEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderFoto = await _context.SliderFoto.FindAsync(id);
            if (sliderFoto == null)
            {
                return NotFound();
            }
            return View(sliderFoto);
        }

        // POST: SliderFotoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SliderEdit(int id, [Bind("sliderFotoId,fotoUrl,fotoBaslik,fotoAciklama")] SliderFoto sliderFoto)
        {
            if (id != sliderFoto.sliderFotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sliderFoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderFotoExists(sliderFoto.sliderFotoId))
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
            return View(sliderFoto);
        }

        // GET: SliderFotoes/Delete/5
        public async Task<IActionResult> SliderDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderFoto = await _context.SliderFoto
                .FirstOrDefaultAsync(m => m.sliderFotoId == id);
            if (sliderFoto == null)
            {
                return NotFound();
            }

            return View(sliderFoto);
        }

        // POST: SliderFotoes/Delete/5
        [HttpPost, ActionName("SliderDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SliderDeleteConfirmed(int id)
        {
            var sliderFoto = await _context.SliderFoto.FindAsync(id);
            _context.SliderFoto.Remove(sliderFoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }

        private bool SliderFotoExists(int id)
        {
            return _context.SliderFoto.Any(e => e.sliderFotoId == id);
        }


        //FOTO BİLGİLERİ


        // GET: Fotoes
        public async Task<IActionResult> Foto()
        {
            return View(await _context.Foto.ToListAsync());
        }

        // GET: Fotoes/Details/5
        public async Task<IActionResult> FotoDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Foto
                .FirstOrDefaultAsync(m => m.fotoId == id);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // GET: Fotoes/Create
        public IActionResult FotoCreate()
        {
            return View();
        }

        // POST: Fotoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FotoCreate([Bind("fotoId,fotoUrl,fotoBaslik,fotoAciklama,fotoWidth")] Foto foto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Foto));
            }
            return View(foto);
        }

        // GET: Fotoes/Edit/5
        public async Task<IActionResult> FotoEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Foto.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }
            return View(foto);
        }

        // POST: Fotoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FotoEdit(int id, [Bind("fotoId,fotoUrl,fotoBaslik,fotoAciklama,fotoWidth")] Foto foto)
        {
            if (id != foto.fotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotoExists(foto.fotoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Foto));
            }
            return View(foto);
        }

        // GET: Fotoes/Delete/5
        public async Task<IActionResult> FotoDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Foto
                .FirstOrDefaultAsync(m => m.fotoId == id);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // POST: Fotoes/Delete/5
        [HttpPost, ActionName("FotoDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FotoDeleteConfirmed(int id)
        {
            var foto = await _context.Foto.FindAsync(id);
            _context.Foto.Remove(foto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Foto));
        }

        private bool FotoExists(int id)
        {
            return _context.Foto.Any(e => e.fotoId == id);
        }


        //BLOG BİLGİLERİ


        // GET: Blogs
        public async Task<IActionResult> Blog()
        {
            return View(await _context.Blog.ToListAsync());
        }

        // GET: Blogs/Details/5
        public async Task<IActionResult> BlogDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog
                .FirstOrDefaultAsync(m => m.blogId == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Blogs/Create
        public IActionResult BlogCreate()
        {
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BlogCreate([Bind("blogId,idName,blogTur,baslik,altBaslik,aciklama,uyari,fotoUrl,videoUrl,iframeUrl,icerikLinki,linkAciklama,eklemeTarihi,degistirmeTarihi,surum,boyut")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Blog));
            }
            return View(blog);
        }

        // GET: Blogs/Edit/5
        public async Task<IActionResult> BlogEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BlogEdit(int id, [Bind("blogId,idName,blogTur,baslik,altBaslik,aciklama,uyari,fotoUrl,videoUrl,iframeUrl,icerikLinki,linkAciklama,eklemeTarihi,degistirmeTarihi,surum,boyut")] Blog blog)
        {
            if (id != blog.blogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.blogId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Blog));
            }
            return View(blog);
        }

        // GET: Blogs/Delete/5
        public async Task<IActionResult> BlogDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog
                .FirstOrDefaultAsync(m => m.blogId == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("BlogDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BlogDeleteConfirmed(string name)
        {
            var blog = await _context.Blog.FindAsync(name);
            _context.Blog.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Blog));
        }

        private bool BlogExists(int id)
        {
            return _context.Blog.Any(e => e.blogId == id);
        }


        //İÇERİK BİLGİLERİ



        // GET: Iceriks
        public async Task<IActionResult> Icerik()
        {
            var veriContext = _context.Icerik.Include(i => i.Blog);
            return View(await veriContext.ToListAsync());
        }

        // GET: Iceriks/Details/5
        public async Task<IActionResult> IcerikDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .Include(i => i.Blog)
                .FirstOrDefaultAsync(m => m.icerikId == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }

        // GET: Iceriks/Create
        public IActionResult IcerikCreate()
        {
            ViewData["blogId"] = new SelectList(_context.Blog, "blogId", "blogId");
            return View();
        }

        // POST: Iceriks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IcerikCreate([Bind("icerikId,baslik,idTag,metinUst,metinAlt,madde,blogId")] Icerik icerik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(icerik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Icerik));
            }
            ViewData["blogId"] = new SelectList(_context.Blog, "blogId", "blogId", icerik.blogId);
            return View(icerik);
        }

        // GET: Iceriks/Edit/5
        public async Task<IActionResult> IcerikEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik.FindAsync(id);
            if (icerik == null)
            {
                return NotFound();
            }
            ViewData["blogId"] = new SelectList(_context.Blog, "blogId", "blogId", icerik.blogId);
            return View(icerik);
        }

        // POST: Iceriks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IcerikEdit(int id, [Bind("icerikId,baslik,idTag,metinUst,metinAlt,madde,blogId")] Icerik icerik)
        {
            if (id != icerik.icerikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(icerik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IcerikExists(icerik.icerikId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Icerik));
            }
            ViewData["blogId"] = new SelectList(_context.Blog, "blogId", "blogId", icerik.blogId);
            return View(icerik);
        }

        // GET: Iceriks/Delete/5
        public async Task<IActionResult> IcerikDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .Include(i => i.Blog)
                .FirstOrDefaultAsync(m => m.icerikId == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }

        // POST: Iceriks/Delete/5
        [HttpPost, ActionName("IcerikDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IcerikDeleteConfirmed(int id)
        {
            var icerik = await _context.Icerik.FindAsync(id);
            _context.Icerik.Remove(icerik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Icerik));
        }

        private bool IcerikExists(int id)
        {
            return _context.Icerik.Any(e => e.icerikId == id);
        }
    }
}
