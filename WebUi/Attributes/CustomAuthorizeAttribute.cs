using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Attributes
{
    public class CustomAuthorizeAttribute: System.Web.Mvc.AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            User currentUser=(User)filterContext.HttpContext.Session[ "user"];
            if (currentUser==null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { controller = "Error", action = "Index" }));
            }
            
        }
    }
}