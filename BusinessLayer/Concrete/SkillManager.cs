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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(x => x.SkillId == id);
        }

        public List<Skill> GetList()
        {
            return _skillDal.List();
        }

        public void SkillAdd(Skill p)
        {
            _skillDal.Insert(p);
        }

        public void SkillDelete(Skill p)
        {
            _skillDal.Delete(p);
        }

        public void SkillUpdate(Skill p)
        {
            _skillDal.Update(p);
        }
    }
}
