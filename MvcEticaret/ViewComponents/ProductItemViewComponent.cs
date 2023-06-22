using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Collections.Generic;

namespace MvcEticaret.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, string imageUrl, int starCount, bool isSale, decimal oldPrice, decimal price)
        {
            var product = new ProductItemViewModel()
            {
                title = title,
                price = price,
                imageUrl = imageUrl,
                isSale = isSale,
                oldPrice = oldPrice,
                starCount = starCount
            };

            return View(product);
        }
    }
}
