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
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {
            PersonManager personManager = new PersonManager(new EfPersonDal());
            SkillManager skillManager = new SkillManager(new EfSkillDal());
          
            viewmodel vm = new viewmodel();
            vm.People =personManager.GetList();
            vm.Skills = skillManager.GetList();
            return View(vm);
        }
    }
}