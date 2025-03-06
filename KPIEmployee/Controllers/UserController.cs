using KPIapplication.Abstraction;
using KPIapplication.ModelDTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIEmployee.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserModel model)
        {
            var r =   await _userService.CreateAsync(model);
            if(r > 0)
            {
                return RedirectToAction(nameof(GetAllUsers));
            }
            return View(r);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var model = await _userService.GetllAsync();
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
