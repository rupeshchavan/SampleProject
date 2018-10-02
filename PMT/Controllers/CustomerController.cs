using PMT.Authenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMT.Controllers
{
    
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userid, string password)
        {
            //PMT.OfiiceBoy.clsSendMail cls = new OfiiceBoy.clsSendMail();
            //cls.SendMail("rupesh.cn@gmail.com", "Test","Test Email");
            ViewBag.UserName = userid;
            return View("CustomerLanding");
        }

        public ActionResult Registration()
        {
            return View();
        }

    }

   
}