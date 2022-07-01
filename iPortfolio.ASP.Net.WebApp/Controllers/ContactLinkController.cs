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
    public class ContactLinkController : Controller
    {
        ContactLinkManager contactLinkManager = new ContactLinkManager(new EfContactLinkDal());
        LinkValidator validationRules = new LinkValidator();
        public ActionResult Index()
        {
            var item = contactLinkManager.GetList();
            return View(item);
        }
        [HttpGet]
        public ActionResult EditLink(int id)
        {
            var item = contactLinkManager.GetById(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult EditLink(ContactLink p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                contactLinkManager.UpdateLink(p);
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
    }
}