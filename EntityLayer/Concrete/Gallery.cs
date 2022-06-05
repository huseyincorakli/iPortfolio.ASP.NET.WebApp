﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ImageUrl { get; set; }
    }
}
