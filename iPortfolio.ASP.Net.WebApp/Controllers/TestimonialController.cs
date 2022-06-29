using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimoManager = new TestimonialManager(new EfTestimonialDal());
        
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
            testimoManager.TestimonialAdd(p);
            return RedirectToAction("Testimonial");
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