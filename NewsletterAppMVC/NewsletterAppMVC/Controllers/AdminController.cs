﻿using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                //var signups = db.Signups.Where(x=> x.Removed == null).ToList(); // filtering names by removing unsubscribers using lambda
                var signups = (from c in db.Signups
                               where c.Removed == null
                               select c).ToList(); // filtering names by removing unsubscribers using LINQ
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.Signups.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}