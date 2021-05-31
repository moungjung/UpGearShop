using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UpGearShop.Models;

namespace UpGearShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().HasData(new { Id = 1, Name = "Coco",  Price=(decimal)23});
            builder.Entity<Product>().HasData(new { Id = 2, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 3, Name = "Yeezys", Price = (decimal)12.99 });
            builder.Entity<Product>().HasData(new { Id = 4, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 5, Name = "CCIV", Price = (decimal)43.99 });
            builder.Entity<Product>().HasData(new { Id = 6, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 7, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 8, Name = "Jordans", Price = (decimal)13.99 });
        }
    }
}
