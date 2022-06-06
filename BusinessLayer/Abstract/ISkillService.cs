using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface ISkillService
    {
        List<Skill> GetList();
        void SkillAdd(Skill p);
        Skill GetById(int id);
        void SkillDelete(Skill p);
        void SkillUpdate(Skill p);
    }
}
