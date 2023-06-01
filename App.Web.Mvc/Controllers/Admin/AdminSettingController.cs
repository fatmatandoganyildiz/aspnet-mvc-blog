using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminSettingController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
