using PMT.Authenticator;
using PMT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult CommingSoon()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutUs(FeedbackForm objFeedback)
        {
            if (ModelState.IsValid)
            {
                // Code here if successful.
                PMT.OfiiceBoy.clsSendMail cls = new OfiiceBoy.clsSendMail();
                cls.SendMail("propertyintermediator@gmail.com", "Name : " + objFeedback.Email + ", Mobile : " + objFeedback.Mobile, objFeedback.Feedback);
                return Redirect(Url.Content("~/"));
            }
            else
            {
                return View(objFeedback);
            }
            
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}