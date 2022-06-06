using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IEduInfoService
    {
        List<EducationInfo> GetList();
        void EducationInfoAdd(EducationInfo p);
        EducationInfo GetById(int id);
        void EducationInfoDelete(EducationInfo p);
        void EducationInfoUpdate(EducationInfo p);
    }
}
