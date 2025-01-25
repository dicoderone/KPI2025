using Microsoft.AspNetCore.Mvc;

namespace KPIEmployee.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
