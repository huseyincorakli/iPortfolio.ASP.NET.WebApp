using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    [Authorize]
    public class ExperienceController : Controller
    {
        ExperienceInfoManager experienceManager = new ExperienceInfoManager(new EfExperienceInfoDal());
        ExperienceInfoValidator validationRules = new ExperienceInfoValidator();
        public ActionResult Index()
        {
            var item = experienceManager.ListByDate();
            return View(item);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(ExperienceInfo p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                experienceManager.AddExperience(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditExperience(int id)
        {
            var item = experienceManager.GetBy(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult EditExperience(ExperienceInfo p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                experienceManager.UpdateExperience(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
        public ActionResult DeleteExperience(int id)
        {
            var item = experienceManager.GetBy(id);
            experienceManager.DeleteExperience(item);
            return RedirectToAction("Index");
        }
    }
}