using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGearShop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CheckoutController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        //public async Task<ViewResult> Index()
        //{
        //    var data = await _productRepository.GetAllProduct();

        //    return View(data);
        //}
        public IActionResult Index()
        {
            return View();
        }
    }

}
