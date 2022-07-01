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
    public class TestimonialController : Controller
    {
        TestimonialManager testimoManager = new TestimonialManager(new EfTestimonialDal());
        TestimonialValidator validationRules = new TestimonialValidator();

        public ActionResult Testimonial()
        {
            var item = testimoManager.GetList();
            return View(item);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var item = testimoManager.GetById(id);
            testimoManager.TestimonialDelete(item);
            return RedirectToAction("Testimonial");
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                testimoManager.TestimonialAdd(p);
                return RedirectToAction("Testimonial");
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
        public ActionResult EditTestimonial(int id)
        {
            var item = testimoManager.GetById(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult EditTestimonial(Testimonial p)
        {
            testimoManager.TestimonialUpdate(p);
            return RedirectToAction("Testimonial");

        }

    }
}