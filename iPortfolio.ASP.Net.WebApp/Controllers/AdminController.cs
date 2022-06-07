﻿using BusinessLayer.Concrete;
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
            p.Password= passwordHash.hash(p.Password);
            adminManager.AdminUpdate(p);

            return RedirectToAction("Edit");
        }
    }
}