using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminBlogController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
