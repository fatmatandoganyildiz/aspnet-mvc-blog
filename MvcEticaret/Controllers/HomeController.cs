using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
 
        public IActionResult Index()
        {
            var products = new List<ProductItemViewModel>()
            {
                new ProductItemViewModel
                {
                    title = "Bouquet 1", starCount = 2, oldPrice = 7500m, price = 5500m, imageUrl = "/images/flower1.jpg", isSale = true
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 2", starCount = 3, oldPrice = 6500m, price = 4500m, imageUrl = "/images/flower10.jpg", isSale = true
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 3", starCount = 5, oldPrice = 7000m, price = 5000m, imageUrl = "/images/flower3.jpg", isSale = false
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 4", starCount = 1, oldPrice = 13500m, price = 10500m, imageUrl = "/images/flower4.jpg", isSale = false
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 5", starCount = 5, oldPrice = 8500m, price = 6500m, imageUrl = "/images/flower5.jpg", isSale = true
                },
                new ProductItemViewModel
                {
                    title ="Bouquet 6", starCount = 4, oldPrice = 19500m, price = 12500m, imageUrl = "/images/flower6.jpg", isSale = true
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 7", starCount = 5, oldPrice = 17500m, price = 10500m, imageUrl = "/images/flower7.jpg", isSale = true
                },
                new ProductItemViewModel
                {
                    title = "Bouquet 8", starCount = 3, oldPrice = 18500m, price = 11500m, imageUrl = "/images/flower12.jpg", isSale = false
                }
            };

            return View(products);
        }

        public IActionResult Privacy()
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