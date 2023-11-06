using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CodeFirst_Prj.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext():base("connectstr")
        { }

        public DbSet<Product> Products { get; set; }
    }
}