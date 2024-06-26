﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int Departmanİd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanAd { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}