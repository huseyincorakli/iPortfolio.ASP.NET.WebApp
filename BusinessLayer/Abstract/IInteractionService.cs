using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
     public interface IInteractionService
    {
        List<Interaction> GetList();
        void InteractionAdd(Interaction p);
        Interaction GetById(int id);
        void InteractionDelete(Interaction p);
        void InteractionUpdate(Interaction p);
    }
}
