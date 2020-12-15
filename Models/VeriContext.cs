using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class VeriContext : DbContext
    {
        public VeriContext(DbContextOptions<VeriContext> options) : base(options)
        {

        }
        public DbSet<Site> Site { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<SliderFoto> SliderFoto { get; set; }
        public DbSet<WebSiteProje.Models.Sosyal> Sosyal { get; set; }

    }
}
