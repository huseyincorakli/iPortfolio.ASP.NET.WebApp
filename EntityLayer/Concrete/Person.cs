﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [StringLength(50)]
        public string PersonNameSurname { get; set; }
        public DateTime  PersonBirthday { get; set; }
        [StringLength(50)]
        public string PersonGsm { get; set; }
        [StringLength(50)]
        public string PersonEmail { get; set; }
        [StringLength(50)]
        public string PersonCity { get; set; }
        [StringLength(50)]
        public string PersonJob { get; set; }
        [StringLength(50)]
        public string PersonExperience { get; set; }
        [StringLength(80)]
        public string PersonAboutHead { get; set; }
        [StringLength(300)]
        public string PersonAboutBody { get; set; }

        [StringLength(400)]
        public string Intro { get; set; }
        
        [StringLength(20)]
        public string FreelanceStatus { get; set; }
        [StringLength(250)]
        public string PhotoUrl { get; set; }
    }
}
