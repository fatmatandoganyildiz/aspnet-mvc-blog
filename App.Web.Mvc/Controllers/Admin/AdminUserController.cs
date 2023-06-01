using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminUserController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
