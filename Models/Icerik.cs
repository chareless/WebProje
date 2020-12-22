using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Icerik
    {
        [Key]
        public int icerikId { get; set; }

        [Display(Name = "Başlık")]
        public string baslik { get; set; }

        [Display(Name = "ID Etiket")]

        public string idTag { get; set; }

        [Display(Name = "Üst İçerik")]
        public string metinUst { get; set; }

        [Display(Name = "Alt İçerik")]
        public string metinAlt { get; set; }

        [Display(Name = "Madde(¿ ile split yapar)")]
        public string madde { get; set; }

        [Display(Name = "BlogID")]
        public int blogId { get; set; }

        [ForeignKey("blogId")]
        public Blog Blog { get; set; }


    }
}
