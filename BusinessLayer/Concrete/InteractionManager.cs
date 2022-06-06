using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class InteractionManager : IInteractionService
    {
        IInteractionDal _interactionDal;
        public InteractionManager(IInteractionDal interactionDal)
        {
            _interactionDal = interactionDal;
        }
        public Interaction GetById(int id)
        {
            return _interactionDal.Get(x => x.InteractionId == id);
        }

        public List<Interaction> GetList()
        {
            return _interactionDal.List();
        }

        public void InteractionAdd(Interaction p)
        {
            _interactionDal.Insert(p);
        }

        public void InteractionDelete(Interaction p)
        {
            _interactionDal.Delete(p);
        }

        public void InteractionUpdate(Interaction p)
        {
            _interactionDal.Update(p);
        }
    }
}
