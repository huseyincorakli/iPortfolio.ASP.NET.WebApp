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
        [StringLength(200)]
        public string InteractionDiscription { get; set; }
        public int  HappyClients { get; set; }
        public int  CompletedProject { get; set; }
        public int HourOfSupport  { get; set; }
        

    }
}
