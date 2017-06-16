using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MondayWeb.Controllers
{
    public class HomeController : Controller
    {
        public String HelloWorld()
        {
            return "Hello World";
        }

        public ActionResult Index()
        {
            //write app logic for invoking the model
            //model might encapsulate backed data stuff
            //do whatever... biz logic...
            //create an object to send to the view
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}