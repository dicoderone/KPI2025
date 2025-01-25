using Microsoft.AspNetCore.Mvc;

namespace KPIEmployee.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
