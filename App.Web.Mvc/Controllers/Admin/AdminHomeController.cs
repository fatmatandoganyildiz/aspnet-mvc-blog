using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminHomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
