using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using iPortfolio.ASP.Net.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    [AllowAnonymous]
    public class MainController : Controller
    {
        PersonManager personManager = new PersonManager(new EfPersonDal());
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        EducationInfoManager eduManager = new EducationInfoManager(new EfEducationInfoDal());
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        InteractionManager interactionManager = new InteractionManager(new EfInteractionDal());
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        ExperienceInfoManager experienceManager = new ExperienceInfoManager(new EfExperienceInfoDal());
        ContactLinkManager contactLinkManager = new ContactLinkManager(new EfContactLinkDal());
        public ActionResult Index()
        {
            MainModel md = new MainModel();
            md.name = personManager.GetPerson().PersonNameSurname;
            md.aboutme = personManager.GetPerson().PersonAboutBody;
            md.aboutheader = personManager.GetPerson().PersonAboutHead;
            md.experience = personManager.GetPerson().PersonExperience;
            md.city = personManager.GetPerson().PersonCity;
            md.birtday = personManager.GetPerson().PersonBirthday;
            md.gsm = personManager.GetPerson().PersonGsm;
            md.mail = personManager.GetPerson().PersonEmail;
            md.job = personManager.GetPerson().PersonJob;
            md.intro = personManager.GetPerson().Intro;
            md.photo = personManager.GetPerson().PhotoUrl;
            md.freelanceStatus = personManager.GetPerson().FreelanceStatus;
            md.Skills = skillManager.GetList();
            md.EducationInfos = eduManager.ListByDate();
            md.Interactions = interactionManager.GetList();
            md.Testimonials = testimonialManager.GetList();
            md.Galleries = galleryManager.GetList();
            md.ExperienceInfos = experienceManager.ListByDate();
            md.twitter = contactLinkManager.GetById(1).LinkUrl;
            md.facebook = contactLinkManager.GetById(2).LinkUrl;
            md.instagram = contactLinkManager.GetById(3).LinkUrl;
            md.linkedin = contactLinkManager.GetById(4).LinkUrl;
            return View(md);
        }
    }
}