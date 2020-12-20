using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Alldata
    {
        public List<Site> Site { get; set; }
        public List<Foto> Foto { get; set; }
        public List<Okul> Okul { get; set; }
        public List<Yorum> Yorum { get; set; }
        public List<Blog> Blog { get; set; }
        public List<Icerik> Icerik { get; set; }
        public List<Sosyal> Sosyal { get; set; }
        public List<Kullanici> Kullanici { get; set; }
        public List<SliderFoto> SliderFoto { get; set; }

        public Site site { get; set; }
        public Foto foto { get; set; }
        public Okul okul { get; set; }
        public Yorum yorum { get; set; }
        public Blog blog { get; set; }
        public Icerik icerik { get; set; }
        public Sosyal sosyal { get; set; }
        public Kullanici kullanici { get; set; }
        public SliderFoto sliderfoto { get; set; }
    }
}
