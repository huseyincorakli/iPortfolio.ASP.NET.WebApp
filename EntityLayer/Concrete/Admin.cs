﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
