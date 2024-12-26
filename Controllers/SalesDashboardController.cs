using Microsoft.AspNetCore.Mvc;

namespace CRMSardis.Controllers
{
    public class SalesDashboardController : Controller
    {
        public IActionResult Index()
        {
            // Kullanıcı adını oturumdan çek ve ViewBag'e aktar
            var userFullName = HttpContext.Session.GetString("UserFullName");
            ViewBag.UserFullName = string.IsNullOrEmpty(userFullName) ? "Kullanıcı" : userFullName;

            return View();
        }
    }
}
