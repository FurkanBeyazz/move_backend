﻿using Microsoft.AspNetCore.Mvc;

namespace move_app_backend
{
	public class AccountController : Controller
	{
		public IActionResult SignIn()
		{
			return View();
		}
		public IActionResult SignUp()
		{
			return View();
		}
	}
}