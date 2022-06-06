using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Interaction
    {
        [Key]
        public int InteractionId { get; set; }
        [StringLength(50)]
        public string InteractionDiscription { get; set; }
        [StringLength(20)]
        public string InteractionName { get; set; }
        public int InteractionValue { get; set; }


    }
}
