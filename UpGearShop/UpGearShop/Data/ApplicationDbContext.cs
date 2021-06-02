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
            builder.Entity<Product>().HasData(new { Id = 1, imageURL = "/images/products-images/yeezys.jpg", NewProduct = true, Name = "Coco", Price = (decimal)23 }) ;
            builder.Entity<Product>().HasData(new { Id = 2, imageURL = "/images/products-images/jacketUgly.jpg", NewProduct = true, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 3, imageURL = "/images/products-images/yeezys.jpg", NewProduct = false, Name = "Yeezys", Price = (decimal)12.99 });
            builder.Entity<Product>().HasData(new { Id = 4, imageURL = "/images/products-images/womanRedDress.jpg", NewProduct = true, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 5, imageURL = "/images/products-images/yeezys.jpg", NewProduct = false, Name = "CCIV", Price = (decimal)43.99 });
            builder.Entity<Product>().HasData(new { Id = 6, imageURL = "/images/products-images/yeezys2.jpg", NewProduct = true, Name = "Bright Shoes", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 7, imageURL = "/images/products-images/yeezys.jpg", NewProduct = false, Name = "Hunger", Price = (decimal)23 });
            builder.Entity<Product>().HasData(new { Id = 8, imageURL = "/images/joe.jpg", NewProduct = true, Name = "Jordans", Price = (decimal)13.99 });
        }
    }
}
