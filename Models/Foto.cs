﻿using System;
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

        public string fotoUrl { get; set; }
        public string fotoBaslik { get; set; }
        public string fotoAciklama { get; set; }
        public string fotoWidth { get; set; }
    }
}