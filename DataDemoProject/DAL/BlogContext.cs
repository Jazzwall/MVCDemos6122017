﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataDemoProject.DAL
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
