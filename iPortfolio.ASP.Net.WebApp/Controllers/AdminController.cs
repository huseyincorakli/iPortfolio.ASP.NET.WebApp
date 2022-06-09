using BusinessLayer.Concrete;
using BusinessLayer.Hash;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    
    public class AdminController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        PasswordHash passwordHash = new PasswordHash();
        
       [HttpGet] [Authorize]
        public ActionResult Edit()
        {
            var username = (string)Session["Username"];
            var id = adminManager.GetByUsername(username).AdminId;
            var user = adminManager.GetById(id);
            
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(Admin p)
        {
            AdminValidator adminValidator = new AdminValidator();
            ValidationResult validationResult = adminValidator.Validate(p);
           
            if (validationResult.IsValid)
            {
                p.Password = passwordHash.hash(p.Password);
                adminManager.AdminUpdate(p);

                return RedirectToAction("Edit");
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