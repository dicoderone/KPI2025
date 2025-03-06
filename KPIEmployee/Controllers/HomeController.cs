using KPIapplication.Abstraction;
using KPIapplication.ModelDTO;
using KPIapplication.Repositories;
using KPIEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KPIEmployee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImportDoc()
        {
            return View();
        }
    }
}
