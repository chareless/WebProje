using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Okul
    {
        [Key]
        public int okulId { get; set; }
        public string okulAd { get; set; }
        public string okulTarih { get; set; }
        public string okulTur { get; set; }
        public string okulInfo { get; set; }
    }
}
