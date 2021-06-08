using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGearShop.Data;
using UpGearShop.Models;

namespace UpGearShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context = null;
        private readonly IConfiguration _configuration;

        public ProductRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return await _context.Products
                  .Select(product => new Product()
                  {
                      Id = product.Id,
                      Name = product.Name,
                      Price = product.Price,
                      NewProduct = product.NewProduct,
                      imageURL = product.imageURL
                  }).ToListAsync();
        }
        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.Where(x => x.Id == id)
                 .Select(product => new Product()
                 {
                     Name = product.Name,
                     Price = product.Price,
                     imageURL = product.imageURL,
                     Id = product.Id,
                     NewProduct = product.NewProduct
                 }).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> SearchProducts(string name)
        {
            return await _context.Products.Where(x => x.Name.Contains(name))
                .Select(product => new Product()
                {
                    Name = product.Name,
                    Price = product.Price,
                    imageURL = product.imageURL,
                    Id = product.Id,
                    NewProduct = product.NewProduct
                }).ToListAsync();
        }

    }
}
