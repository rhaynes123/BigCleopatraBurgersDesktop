using System;
using System.Collections.Generic;
using System.Text;
using BigCleopatraBurgers.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BigCleopatraBurgers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>(o => {
                o.HasKey(o => o.Id);
                o.Property(o => o.OrderNumber);
                o.Property(o => o.Status);
                o.Property(o => o.OrderDateTime);
                o.Property(o => o.Total);
            });
            builder.Entity<OrderedProduct>(op => {
                op.HasKey(op => op.Id);
                op.Property(op => op.OrderNumber);
                op.Property(op => op.Name);
                op.Property(op => op.Price);
                op.Property(op => op.OrderDateTime);
                op.Property(op => op.ProductId);
                op.Property(op => op.Status);
            });
            builder.Entity<Product>(p => {
                p.HasKey(p => p.Id);
                p.Property(p => p.Name);
                p.Property(p => p.Price);
                p.Property(p => p.Active);
            });
        }
    }
}

