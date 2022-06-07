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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(Admin p)
        {
            _adminDal.Insert(p);
        }

        public void AdminDelete(Admin p)
        {
            _adminDal.Delete(p);
        }

        public void AdminUpdate(Admin p)
        {
            _adminDal.Update(p);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public Admin GetByInfo(string password, string username)
        {
            return _adminDal.Get(x => x.Password == password &&  x.Username==username);
        }

        public List<Admin> ListByInfo(string password, string username)
        {
            return _adminDal.List(x => x.Username == username && x.Password == password);
        }
    }
}
