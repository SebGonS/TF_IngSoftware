using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DataAccess
{
    public class EcommerceDbContext:DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext>options)
            : base(options) 
        {
        }
        public EcommerceDbContext()  
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder
                .UseSqlServer(@"Server = DESKTOP-V50KMET\jadv; Database=EcommerceDb; Integrated Security = true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
} 