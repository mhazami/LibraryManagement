using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.WebApp.App_Code
{
    internal class SessionParameters
    {
        public static User User
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return (User)HttpContext.Current.Session["User"];
                return null;
            }
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }
    }
}