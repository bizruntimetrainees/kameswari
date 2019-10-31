using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication3.Models
{
    class NorthWindContext : DbContext
    {
        public NorthWindContext()
            : base("name=NorthwindConnection")
        {

        }
        public DbSet<Category> CategoryTable { get; set; }
        public DbSet<Category> ProductTable { get; set; }
        public object CategoriesTable { get; set; }
        public object Category { get;  set; }
    }
}

