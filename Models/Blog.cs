using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Blog
    {
        [Key]
        public int blogId { get; set; }

        public string baslik { get; set; }
        public string altBaslik { get; set; }
        public string aciklama { get; set; }
        public string fotoUrl { get; set; }
        public string videoUrl { get; set; }
        public string icerikLinki { get; set; }
        public string eklemeTarihi { get; set; }
        public string surum { get; set; }
        public string boyut { get; set; }
        public string icerikYonlendirmeUrl { get; set; }

        public Icerik icerik { get; set; }

    }
}
