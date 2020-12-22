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
        [Display(Name = "BlogID")]
        public int blogId { get; set; }

        [Display(Name = "ID Name")]
        public string idName { get; set; }

        [Display(Name = "Blog Türü")]
        public string blogTur { get; set; }

        [Display(Name = "Başlık")]
        public string baslik { get; set; }

        [Display(Name = "Alt Başlık")]
        public string altBaslik { get; set; }

        [Display(Name = "Açıklama")]
        public string aciklama { get; set; }

        [Display(Name = "Uyarı")]
        public string uyari { get; set; }

        [Display(Name = "Foto URL")]
        public string fotoUrl { get; set; }

        [Display(Name = "Video URL")]
        public string videoUrl { get; set; }

        [Display(Name = "Iframe URL")]
        public string iframeUrl { get; set; }

        [Display(Name = "İçerik Linki")]
        public string icerikLinki { get; set; }

        [Display(Name = "Link Açıklama")]
        public string linkAciklama { get; set; }

        [Display(Name = "Ekleme Tarihi")]
        public string eklemeTarihi { get; set; }

        [Display(Name = "Değiştirme Tarihi")]
        public string degistirmeTarihi { get; set; }

        [Display(Name = "Sürüm")]
        public string surum { get; set; }

        [Display(Name = "Boyut")]
        public string boyut { get; set; }
        public ICollection<Icerik> icerik { get; set; }


    }
}
