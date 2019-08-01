using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;

namespace InfinityDotCom.DatabaseContext.DatabaseContext
{
    public class InfinityDBContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
    }
}
