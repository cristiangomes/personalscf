using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PersonalSCF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                
            }
            return View();
        }

        public ActionResult Inicial()
        {
            return View();
        }
    }
}