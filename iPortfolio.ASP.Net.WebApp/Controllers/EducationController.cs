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
    public class EducationController : Controller
    {
        EducationInfoManager eduInfoManager = new EducationInfoManager(new EfEducationInfoDal());
        // GET: Education
        public ActionResult ListEducationInfo()
        {
           var eduList= eduInfoManager.GetList();
            return View(eduList);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(EducationInfo p)
        {
            EducationValidator validationRules = new EducationValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                eduInfoManager.EducationInfoAdd(p);
                return RedirectToAction("ListEducationInfo");
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

        public ActionResult DeleteEducation(int id)
        {
            var item = eduInfoManager.GetById(id);
            eduInfoManager.EducationInfoDelete(item);
            return RedirectToAction("ListEducationInfo");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var item = eduInfoManager.GetById(id);

            return View(item);
        }
        [HttpPost]
        public ActionResult UpdateEducation(EducationInfo p)
        {
            EducationValidator validationRules = new EducationValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                eduInfoManager.EducationInfoUpdate(p);
                return RedirectToAction("ListEducationInfo");
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
    }
}