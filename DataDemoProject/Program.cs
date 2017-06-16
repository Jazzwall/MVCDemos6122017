using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDemoProject.DAL;
namespace DataDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new BlogContext())
            //{
            //    ctx.Blogs.Add(new DAL.Blog() { BlogId = 1, Name = "DIY Bitcoin Mining" });
            //    ctx.SaveChanges();
            //}

            using (var ctx = new BlogContext())
            {
                foreach(Blog b in ctx.Blogs)
                {
                    Console.WriteLine(b.Name);
                }
            }
        }
    }
}
