using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExperienceService
    {
        void AddExperience(ExperienceInfo p);
        void DeleteExperience(ExperienceInfo p);
        void UpdateExperience(ExperienceInfo p);
        List<ExperienceInfo> GetList();
        ExperienceInfo GetBy(int id);
    }
}
