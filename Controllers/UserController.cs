using CRMSardis.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRMSardis.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /User
        public IActionResult Index()
        {
            // Veritabanındaki tüm kullanıcıları getir
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}
