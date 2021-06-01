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
                      NewProduct = product.NewProduct
                  }).ToListAsync();
        }

    }
}
