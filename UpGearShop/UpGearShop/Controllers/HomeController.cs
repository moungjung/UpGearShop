using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UpGearShop.Models;
using UpGearShop.Repository;

namespace UpGearShop.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly IProductRepository _productRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IProductRepository bookRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = bookRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ViewResult> Index()
        {
            var data = await _productRepository.GetAllProduct();

            return View(data);
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
