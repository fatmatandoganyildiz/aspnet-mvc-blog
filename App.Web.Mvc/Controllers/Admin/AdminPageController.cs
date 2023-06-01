using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminPageController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
