using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using ASP.NET_Registration.Models;
using Registration.DataAccsess.Entities.Concretes;
using ASP.NET_Registration.Validators.FluentValidators;
using static ASP.NET_Registration.Services.DatabaseService;

namespace ASP.NET_Registration.Controllers {
    public class UserController : Controller {


        public IActionResult SuccsessfullyLogined() {
            return View();
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user) {

            if (Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password) != null) {
                return RedirectToAction("SuccsessfullyLogined");
            }
            else {
                
                if (Users.FirstOrDefault(u => u.Username == user.Username) != null) {
                    ModelState.AddModelError("Password", "Password for this username incorrect");
                }
                else ModelState.AddModelError("Username", "There is not account with this username");
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register() {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user) {

            UserValidator validator = new();
            ValidationResult result = validator.Validate(user);

            if (result.IsValid) {

                User? checkUserEmail = Users.FirstOrDefault(u => u.Email == user.Email);
                User? checkUserName = Users.FirstOrDefault(u => u.Username == user.Username);

                if (checkUserEmail == null && checkUserName == null) {

                    await AddUserAsync(user);
                    return RedirectToAction("Login");

                }
                else { 

                    if (checkUserName != null) 
                        ModelState.AddModelError("Username", "This username already in use");

                    if (checkUserEmail != null) 
                        ModelState.AddModelError("Email", "This email already in use");

                }
            }
            else {

                foreach (var e in result.Errors) 
                    ModelState.AddModelError(e.PropertyName, e.ErrorMessage);

                return View(user);

            }

            return View(user);
        }

        public IActionResult AllUsers() {
            AllUsersViewModel viewModel = new AllUsersViewModel() {
                Users = Users
            };
            return View(viewModel);
        }
    }
}
