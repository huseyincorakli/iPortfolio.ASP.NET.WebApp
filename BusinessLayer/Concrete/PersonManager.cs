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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public Person GetById(int id)
        {
            return _personDal.Get(x => x.PersonId == id);
        }

        public List<Person> GetList()
        {
            return _personDal.List();
        }

        public Person GetPerson()
        {
            return _personDal.List().FirstOrDefault();
        }

        public void PersonAdd(Person p)
        {
            _personDal.Insert(p);
        }

        public void PersonDelete(Person p)
        {
            _personDal.Delete(p);
        }

        public void PersonUpdate(Person p)
        {
            _personDal.Update(p);
        }
    }
}
