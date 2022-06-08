using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.CRMApp.Core.Entity;
namespace Antra.CRMApp.Infrastructure.Data
{
    public class CrmDbContext:DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> option):base(option)
        {
            
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Region { get; set; }
        public DbSet<Product> Shipper { get; set; }
        public DbSet<Product> Supplier { get; set; }
    }
}
