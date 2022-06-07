using BusinessLayer.Concrete;
using BusinessLayer.Hash;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    
    public class LoginController : Controller
    {   
      
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        PasswordHash passwordHash = new PasswordHash();
                             
           [HttpGet] [AllowAnonymous]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Admin p)
        {
            var hashedPassword = passwordHash.hash(p.Password);
            var adminInfo = adminManager.GetByInfo(hashedPassword, p.Username);
            if (adminInfo!=null)
            {
                FormsAuthentication.SetAuthCookie(p.Username,false);
                Session["Username"] = adminInfo.Username;
                return RedirectToAction("Edit", "Admin");
            }
            else
                return RedirectToAction("SignIn");
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("SignIn");
        }
    }
}