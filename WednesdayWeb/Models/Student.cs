using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WednesdayWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Decimal GPA { get; set; }

        public Student(int id, String name, decimal gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }

        public Student()
        {

        }
    }
}