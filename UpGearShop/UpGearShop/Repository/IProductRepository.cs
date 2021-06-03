using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGearShop.Models;

namespace UpGearShop.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct();
        Task<Product> GetProductById(int id);
    }
}
