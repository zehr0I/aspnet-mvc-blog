﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class PageController : Controller
	{
		public IActionResult Detail()
		{
			return View();
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
