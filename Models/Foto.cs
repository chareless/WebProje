using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Foto
    {
        [Key]
        public int fotoId { get; set; }

        [Display(Name = "URL")]
        public string fotoUrl { get; set; }

        [Display(Name = "Başlık")]
        public string fotoBaslik { get; set; }

        [Display(Name = "Açıklama")]
        public string fotoAciklama { get; set; }

        [Display(Name = "Boyut")]
        public string fotoWidth { get; set; }
    }
}
