using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Yorum
    {
        [Key]
        public int yorumId { get; set; }

        public Kullanici kullanici { get; set; }
        public Blog blog { get; set; }
    }
}
