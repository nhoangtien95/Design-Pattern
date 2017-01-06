using RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Infrastructure
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductAppConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}