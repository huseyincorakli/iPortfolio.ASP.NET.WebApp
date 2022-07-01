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
    public class ContactLinkManager : IContactLinkService
    {
        IContactLinkDal _contactLinkDal;

        public ContactLinkManager(IContactLinkDal contactLinkDal)
        {
            _contactLinkDal = contactLinkDal;
        }

        public ContactLink GetById(int id)
        {
            return _contactLinkDal.Get(x => x.LinkId == id);
        }

        public List<ContactLink> GetList()
        {
            return _contactLinkDal.List();
        }

        public void UpdateLink(ContactLink p)
        {
            _contactLinkDal.Update(p);
        }
    }
}
