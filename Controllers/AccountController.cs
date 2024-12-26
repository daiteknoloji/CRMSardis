using CRMSardis.Data;
using CRMSardis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.AspNetCore.Http; // Session için gerekli

namespace CRMSardis.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AccountController> _logger;

        public AccountController(AppDbContext context, ILogger<AccountController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Kullanıcı bilgilerini logla
                _logger.LogInformation($"Kullanıcı giriş yaptı: {user.Email}, Rol: {user.Role}");

                // Kullanıcı bilgilerini oturuma kaydet
                HttpContext.Session.SetString("UserFullName", $"{user.Name} {user.Surname}");
                HttpContext.Session.SetString("UserRole", user.Role);

                // Kullanıcı rolüne göre yönlendirme
                return user.Role switch
                {
                    "Admin" => RedirectToAction("Index", "AdminDashboard"),
                    "Sales" => RedirectToAction("Index", "SalesDashboard"),
                    "Finance" => RedirectToAction("Index", "FinanceDashboard"),
                    "HR" => RedirectToAction("Index", "HRDashboard"),
                    _ => RedirectToAction("Index", "Home")
                };
            }

            // Başarısız girişte hata mesajı
            ViewBag.ErrorMessage = "Hatalı kullanıcı adı veya şifre.";
            return View();
        }
    }
}
