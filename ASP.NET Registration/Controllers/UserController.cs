using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Registration.Controllers {
    public class UserController : Controller {
        public IActionResult Login() {
            return View();
        }
    }
}
