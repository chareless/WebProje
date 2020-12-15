using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Site
    {
        [Key]
        public int MyId { get; set; }
        public string isim { get; set; }
        public string meslek { get; set; }
        public string profileFotoUrl { get; set; }
        public string backFotoUrl { get; set; }
        public string hakkımda { get; set; }
        public string dogumTarihi { get; set; }
        public string dogumYeri { get; set; }
        public string egitimDurumu { get; set; }
        public string egitimBolumu { get; set; }
        public string diller { get; set; }
        public string adres { get; set; }
        public string adresUrl { get; set; }
        public string email { get; set; }
        public string emailUrl { get; set; }
        public string sliderFotoUrl { get; set; }
        public string sliderFotoBaslik { get; set; }
        public string sliderFotoAciklama { get; set; }
    }
}
