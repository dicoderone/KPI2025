using Microsoft.AspNetCore.Mvc;

namespace KPIauth.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
