using Microsoft.AspNetCore.Mvc;
using ASP.NET_Registration.Models;
using static ASP.NET_Registration.Services.DatabaseService;

namespace ASP.NET_Registration.Controllers {
    public class UserController : Controller {
        public IActionResult Login() {
            return View();
        }

        public IActionResult AllUsers() {
            AllUsersViewModel viewModel = new AllUsersViewModel() {
                Users = Users
            };
            return View(viewModel);
        }
    }
}
