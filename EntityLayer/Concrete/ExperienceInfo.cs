using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class ExperienceInfo
    {
        [Key]
        public int ExperienceId { get; set; }
        [StringLength(50)]
        public string ExperienceHeading { get; set; }
        [StringLength(200)]
        public string ExperienceDescription { get; set; }
        [StringLength(50)]
        public string ExperienceSumaryHead { get; set; }
        public DateTime ExperienceTime { get; set; }
    }
}
