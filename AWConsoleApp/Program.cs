using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWConsoleApp.DAL;
using System.Data.Entity;

namespace AWConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // print to the console, all the products and a few of the fields
            using (var ctx = new AdventureWorks2014Entities())
            {
                foreach(var prod in ctx.Products)
                {
                    Console.WriteLine(prod.Name + " -- $" + prod.ListPrice);
                }
            }

        }
    }
}
