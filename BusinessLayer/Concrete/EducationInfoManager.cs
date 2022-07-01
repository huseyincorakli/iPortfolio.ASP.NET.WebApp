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
    public class EducationInfoManager : IEduInfoService
    {
        IEducationInfoDal _eduInfoDal;
        public EducationInfoManager(IEducationInfoDal educationInfoDal)
        {
            _eduInfoDal = educationInfoDal;
        }
        public void EducationInfoAdd(EducationInfo p)
        {
            _eduInfoDal.Insert(p);
        }

        public void EducationInfoDelete(EducationInfo p)
        {
            _eduInfoDal.Delete(p);
        }

        public void EducationInfoUpdate(EducationInfo p)
        {
            _eduInfoDal.Update(p);
        }

        public EducationInfo GetById(int id)
        {
           return _eduInfoDal.Get(x=>x.EduInfoId==id);
        }

        public List<EducationInfo> GetList()
        {
            return _eduInfoDal.List();
        }
       public List<EducationInfo> ListByDate()
        {
            return _eduInfoDal.List().OrderBy(x => x.EduTime).ToList();
        }
    }
}
