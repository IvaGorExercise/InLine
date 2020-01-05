using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace InLine.UI.Web.Helper
{
    public class RedirectToLogIn
    {
 
        public static System.Web.Mvc.ViewResult RedirectToLoginFunction()
        {
            System.Web.Mvc.ViewResult loginView = new ViewResult();
            loginView.ViewBag.poruka = "Došlo je do prekida veze, molimo Vas prijavite se ponovo";
            loginView.ViewName = "../Home/LogOn";
            return loginView;
        }
    }

} 