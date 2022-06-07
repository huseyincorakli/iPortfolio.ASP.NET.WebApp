using BusinessLayer.Concrete;
using BusinessLayer.Hash;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        PasswordHash passwordHash = new PasswordHash();

           [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin p)
        {
            var hashedPassword = passwordHash.hash(p.Password);
            var adminInfo = adminManager.GetByInfo(hashedPassword, p.Username);
            if (adminInfo!=null)
            {
                return RedirectToAction("Index", "Default");
            }
            else
                return RedirectToAction("Login");
        }
    }
}