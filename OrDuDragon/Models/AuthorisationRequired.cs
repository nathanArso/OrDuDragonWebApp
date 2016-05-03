using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autentification.Controllers
{
    public class AuthorisationRequired : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["User"] != null)
            {
                    return true;
            }
            HttpContext.Current.Response.Redirect("/Users/PermissionInvalide");
            return base.AuthorizeCore(httpContext);
        }
    }
}