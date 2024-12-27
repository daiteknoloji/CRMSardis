using Microsoft.AspNetCore.Mvc;

namespace CRMSardis.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
