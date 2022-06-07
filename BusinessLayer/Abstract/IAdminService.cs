using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IAdminService
    {
        void AdminAdd(Admin p);
        Admin GetById(int id);
        void AdminDelete(Admin p);
        void AdminUpdate(Admin p);
        List<Admin> ListByInfo(string password, string username);
        Admin GetByInfo(string password, string username);
    }
}
