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
    public class ExperienceInfoManager : IExperienceService
    {
        IExperienceInfoDal _experienceInfoDal;

        public ExperienceInfoManager(IExperienceInfoDal experienceInfoDal)
        {
            _experienceInfoDal = experienceInfoDal;
        }

        public void AddExperience(ExperienceInfo p)
        {
            _experienceInfoDal.Insert(p);
        }

        public void DeleteExperience(ExperienceInfo p)
        {
            _experienceInfoDal.Delete(p);
        }

        public ExperienceInfo GetBy(int id)
        {
            return _experienceInfoDal.Get(x => x.ExperienceId == id);
        }

        public List<ExperienceInfo> GetList()
        {
            return _experienceInfoDal.List();
        }

        public void UpdateExperience(ExperienceInfo p)
        {
            _experienceInfoDal.Update(p);
        }
    }
}
