using FridayRestWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FridayRestWeb.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return new Student[] {
                new Student() {Id=1, Name="Spiderman", GPA=3.0M },
                new Student() {Id=2, Name="Wonder Woman", GPA = 3.8M }
            };
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return new Student() { Id = id, Name="John Smith", GPA=3.5M};
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
