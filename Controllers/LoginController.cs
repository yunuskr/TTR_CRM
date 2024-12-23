using Microsoft.AspNetCore.Mvc;
using TTR_CRM.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TTR_CRM.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Login/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login/Index
        [HttpPost]
      public IActionResult Index(string username, string password)
        {
            // Veri tabanındaki Users tablosunda sorgulama yap
            var user = _context.Users.FirstOrDefault(u => 
                u.Username == username && 
                u.Password == password);

            if (user != null)
            {
                // Giriş başarılı
                TempData["Message"] = "Giriş başarılı!";
                return RedirectToAction("Welcome");
            }
            else
            {
                // Giriş başarısız
                ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
