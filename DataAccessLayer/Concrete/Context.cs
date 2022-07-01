using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<EducationInfo> EducationInfoes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ExperienceInfo> ExperienceInfos { get; set; }
        public DbSet<ContactLink> ContactLinks { get; set; }

    }
}
