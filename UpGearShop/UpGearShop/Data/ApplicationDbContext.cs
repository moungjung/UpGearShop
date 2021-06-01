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
            builder.Entity<Product>().HasData(new { Id = 1, NewProduct = true, Name = "Coco", Price = (decimal)23 }) ;
            builder.Entity<Product>().HasData(new { Id = 2, NewProduct = true, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 3, NewProduct = false, Name = "Yeezys", Price = (decimal)12.99 });
            builder.Entity<Product>().HasData(new { Id = 4, NewProduct = true, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 5, NewProduct = false, Name = "CCIV", Price = (decimal)43.99 });
            builder.Entity<Product>().HasData(new { Id = 6, NewProduct = true, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 7, NewProduct = false, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 8, NewProduct = true, Name = "Jordans", Price = (decimal)13.99 });
        }
    }
}
