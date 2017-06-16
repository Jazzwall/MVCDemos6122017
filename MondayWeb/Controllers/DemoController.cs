using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MondayWeb.Models;

namespace MondayWeb.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index(int id)
        {
            ViewBag.CourseName = "ASP .NET MVC 5";
            ViewBag.CourseId = id;
            return View();
        }

        //action method that returns the sum of two numbers back as a string
        public ActionResult Add(int x, int y)
        {
            int sum = x + y;
            ContentResult result = new ContentResult();
            result.Content = sum.ToString();
            return result;
        }

        public ActionResult Multiply(int x, int y)
        {
            int product = x * y;
            ContentResult result = new ContentResult();
            result.Content = product.ToString();
            return result;
        }

        public ActionResult Student(int id)
        {
            List<Student> listOfStudents = new List<Student>();

            Student s = new Student()
            {
                Id = id,
                Name = "Joe Smith",
                Age = 70,
                City = "Sacramento"
            };

            listOfStudents.Add(s);

            Student s2 = new Student()
            {
                Id = id,
                Name = "Jane Smith",
                Age = 40,
                City = "Berkeley"
            };

            listOfStudents.Add(s2);

            return Json(listOfStudents, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WeatherInfo()
        {
            return View();
        }
    }

}