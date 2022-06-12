﻿using BusinessLayer.Concrete;
using BusinessLayer.Hash;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPortfolio.ASP.Net.WebApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        PersonManager personManager = new PersonManager(new EfPersonDal());
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        PasswordHash passwordHash = new PasswordHash();
        
       [HttpGet] 
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

        [HttpGet]
        public ActionResult Profile()
        {
            var person = personManager.GetPerson();

            return View(person);
        }
        [HttpPost]
        public ActionResult Profile(Person p)
        {
            PersonValidator personValidator = new PersonValidator();
            ValidationResult personValResul = personValidator.Validate(p);
            if (personValResul.IsValid)
            {
                personManager.PersonUpdate(p);
                return RedirectToAction("Profile");
            }
            else
            {
                foreach (var item in personValResul.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
         
        }

       
        public ActionResult Gallery()
        {
            var items = galleryManager.GetList();
            return View(items);
        }

       public ActionResult GalleryDeletePhoto(int id)
        {
            var item = galleryManager.GetById(id);
            galleryManager.GalleryDelete(item);
            return RedirectToAction("Gallery");
        }


    }
}