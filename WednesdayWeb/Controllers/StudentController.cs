using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WednesdayWeb.Models;

namespace WednesdayWeb.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //
            List<Student> listofStudents = new List<Student> ();
            listofStudents.Add(new Student(1, "Joe", 3.5M));
            listofStudents.Add(new Student(2, "Jane", 4.0M));
            listofStudents.Add(new Student(3, "Don", 3.8M));

            return View(listofStudents);
        }

        public ActionResult Details(int id)
        {
            Student s = new Student(id, "John Smith", 4.0M);
            return View(s);
        }

        //[HttpGet]
        public ActionResult Edit(int id)
        {
            //do something
            Student s = new Student(id, "John Smith", 4.0M);
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            return View("Details", s);
        }

        
    }
}