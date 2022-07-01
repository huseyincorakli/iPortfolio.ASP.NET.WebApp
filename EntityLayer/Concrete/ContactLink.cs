using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class ContactLink
    {
        [Key]
        public int LinkId { get; set; }
        [StringLength(30)]
        public string LinkName { get; set; }
        [StringLength(250)]
        public string LinkUrl { get; set; }
    }
}
