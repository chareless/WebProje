using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteProje.Models
{
    public class Sosyal
    {
        [Key]
        public int sosyalId { get; set; }
        public string sosyalUrl { get; set; }
        public string sosyalTur { get; set; }
        public string sosyalInfo { get; set; }
        public string sosyalFooter { get; set; }


    }
}
