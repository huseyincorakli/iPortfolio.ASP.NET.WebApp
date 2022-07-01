using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPortfolio.ASP.Net.WebApp.Models
{
    public class MainModel
    {
        public IEnumerable<EducationInfo> EducationInfos { get; set; }
        public IEnumerable<Gallery> Galleries { get; set; }
        public IEnumerable<Interaction> Interactions { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; } 
        public IEnumerable<ExperienceInfo> ExperienceInfos { get; set; } 
        public string name { get; set; }
        public string aboutme { get; set; }
        public DateTime birtday { get; set; }
        public string gsm { get; set; }
        public string mail { get; set; }
        public string city { get; set; }
        public string job { get; set; }
        public string experience { get; set; }
        public string aboutheader { get; set; }
        public string  intro { get; set; }
        public string  freelanceStatus { get; set; }
        public string  photo { get; set; }

        public string twitter { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string linkedin { get; set; }
    }
}