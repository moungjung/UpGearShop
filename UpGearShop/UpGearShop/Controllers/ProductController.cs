using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UpGearShop.Models;
using UpGearShop.Repository;

namespace UpGearShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductRepository bookRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = bookRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ViewResult> GetAllProducts()
        {
            var data = await _productRepository.GetAllProduct();

            return View(data);
        }

        [Route("Product/{id:int:min(1)}", Name = "productDetailsRoute")]
        public async Task<ViewResult> GetIndividualProduct(int id)
        {
            var data = await _productRepository.GetProductById(id);
            return View(data);
        }

        public async Task<IActionResult> SearchProducts(string searchCriteria)
        {
            var data = await _productRepository.SearchProducts(searchCriteria);
            return View(data);
        }

    }
}
