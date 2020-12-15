using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Icerik
    {
        [Key]
        public int icerikId { get; set; }
        public string anaBaslik { get; set; }
        public string fotoUrl { get; set; }
        public string anaBaslikIcerik { get; set; }
        public string anaBaslikMadde { get; set; }
        public string konuBaslik { get; set; }
        public string altBaslikIcerik { get; set; }
        public string altBaslikMadde { get; set; }
        public string duzenlemeTarihi { get; set; }

        public ICollection<Blog> blog { get; set; }

    }
}
