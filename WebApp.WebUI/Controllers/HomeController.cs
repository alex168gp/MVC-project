using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Domain;

namespace WebApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using(CompanyContext company = new CompanyContext())
            {

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            using (CompanyContext company = new CompanyContext())
            {

            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            using (CompanyContext company = new CompanyContext())
            {

            }
            return View();
        }
    }
}