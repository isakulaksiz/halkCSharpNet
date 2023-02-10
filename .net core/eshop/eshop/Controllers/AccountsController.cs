using eshop.Application;
using eshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop.Controllers
{
    public class AccountsController : Controller
    {

        private readonly IUserService userService;

        public AccountsController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(viewModel.UserName, viewModel.Password);
            }

            return View();
        }
    }
}
