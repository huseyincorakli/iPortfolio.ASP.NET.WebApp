using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IContactLinkService
    {
        void UpdateLink(ContactLink p);
        List<ContactLink> GetList();
        ContactLink GetById(int id);
    }
}
