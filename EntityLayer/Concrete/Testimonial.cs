using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Testimonial
    {
        [Key]
        public int TestimoId { get; set; }
        [StringLength(60)]
        public string TestimoNameSurname { get; set; }
        [StringLength(30)]
        public string TestimoTitle { get; set; }
        [StringLength(150)]
        public string TestimoComment { get; set; }
        [StringLength(200)]
        public string TestimoImageUrl { get; set; }
    }
}
