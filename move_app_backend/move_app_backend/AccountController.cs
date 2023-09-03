using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using move_app_backend.Concrate;
using move_app_backend.Model;

namespace move_app_backend
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _siginManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> siginManager)
        {
            _userManager = userManager;
            _siginManager = siginManager;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(Loginmodel signIn)
        {
            var result = await _siginManager.PasswordSignInAsync(signIn.Email, signIn.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "MyProfile");
            }

            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterModel registerModel)
        {
            if (registerModel.Password==registerModel.PasswordR)
            {
				AppUser user = new AppUser()
				{
					UserName = registerModel.UserName,
					Email = registerModel.Email,
					UserCreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
					NameSurname = registerModel.NameSurname
				};

				var result = await _userManager.CreateAsync(user, registerModel.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("SignIn", "Account");
				}
			}
            else
            {
                ViewBag.paswordhas = "Parolar Uyusmamaktadır.";
            }
            
            return View(registerModel);
    }
}
}
