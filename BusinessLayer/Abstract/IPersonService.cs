using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IPersonService
    {
        List<Person> GetList();
        void PersonAdd(Person p);
        Person GetById(int id);
        void PersonDelete(Person p);
        void PersonUpdate(Person p);
    }
}
