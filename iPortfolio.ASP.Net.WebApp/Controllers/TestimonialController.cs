using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        // GET: Testimonial
        public ActionResult Testimonial()
        {
            var item = testimoManager.GetList();
            return View(item);
        }
    }
}