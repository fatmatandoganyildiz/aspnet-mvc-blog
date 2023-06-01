using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminCategoryController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
