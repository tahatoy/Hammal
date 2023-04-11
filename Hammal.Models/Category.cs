﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammal.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        public string? ImgPath { get; set; }
         public string? Aciklama { get; set; }
        public ICollection<AltCategory> AltCategories { get; set; }
  }
}
