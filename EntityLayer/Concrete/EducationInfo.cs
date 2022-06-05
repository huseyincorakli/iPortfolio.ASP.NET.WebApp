using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EducationInfo
    {
        [Key]
        public int EduInfoId { get; set; }
        [StringLength(50)]
        public string EduHeading { get; set; }
        [StringLength(200)]
        public string EduDescription { get; set; }
        [StringLength(50)]
        public string EduSumaryHead { get; set; }
        public DateTime EduTime { get; set; }

    }
}
