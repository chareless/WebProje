using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSiteProje.Models;

namespace WebSiteProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly VeriContext _context;

        public HomeController(VeriContext context)
        {
            _context = context;
        }
        public IActionResult Index()
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
        public IActionResult Blog()
        {
            var site = _context.Site.ToList();
            var blog = _context.Blog.ToList();
            var sosyal = _context.Sosyal.ToList();
            var Class = new Alldata();
            Class.Site = site;
            Class.Blog = blog;
            Class.Sosyal = sosyal;
            return View(Class);
        }

        public IActionResult Arsiv()
        {
            var site = _context.Site.ToList();
            var foto = _context.Foto.ToList();
            var sosyal = _context.Sosyal.ToList();
            var Class = new Alldata();
            Class.Foto = foto;
            Class.Site = site;
            Class.Sosyal = sosyal;
            return View(Class);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
