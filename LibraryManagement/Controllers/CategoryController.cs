using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            //ViewBag.Value = new CategoryBO().Where(c=>c.Title.Contains("tes"));
            return View();
        }
    }
}