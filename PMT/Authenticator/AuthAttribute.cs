using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace PMT.Authenticator
{
    public class AuthAttribute : ActionFilterAttribute, IAuthenticationFilter
    {

       

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //Check Session is Empty Then set as Result is HttpUnauthorizedResult 
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserID"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
        

        //Runs after OnAuthentication method
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //ToDO : Additional task on the request

            var user = filterContext.HttpContext.User;

            if (user == null && !user.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }


    }
}