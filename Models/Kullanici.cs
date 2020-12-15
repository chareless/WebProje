using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Kullanici
    {
        [Key]
        public int id { get; set; }

        public string kadi { get; set; }
        public string sifre { get; set; }
        public string rol { get; set; }
        public string isim { get; set; }
        public string meslek { get; set; }
        public string hakkimda { get; set; }
        public string dogumTarihi { get; set; }
        public string egitimDurumu { get; set; }
        public string egitimBolum { get; set; }
        public string diller { get; set; }
        public string email { get; set; }
    }
}
