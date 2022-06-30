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
    public class InteractionController : Controller
    {
        InteractionManager interactionManager = new InteractionManager(new EfInteractionDal());
        InteractionValidator validationRules = new InteractionValidator();
        public ActionResult Interaction()
        {
            var item = interactionManager.GetList();
            return View(item);
        }
        [HttpGet]
        public ActionResult AddInteraction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInteraction(Interaction p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                interactionManager.InteractionAdd(p);
                return RedirectToAction("Interaction");
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

        public ActionResult DeleteInteraction(int id)
        {
           var item=  interactionManager.GetById(id);
            interactionManager.InteractionDelete(item);
            return RedirectToAction("Interaction");
        }

       

        [HttpGet]
        public ActionResult EditInteraction(int id)
        {
            var item = interactionManager.GetById(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult EditInteraction(Interaction p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                interactionManager.InteractionUpdate(p);
                return RedirectToAction("Interaction");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.ErrorMessage, item.PropertyName);
                }
            }
            return View();
        }
    }
}