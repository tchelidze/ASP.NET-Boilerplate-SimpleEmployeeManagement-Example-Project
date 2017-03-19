﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SimpleEmployeeManagement.Web.Controllers
{
	[AbpMvcAuthorize]
	public class HomeController : SimpleEmployeeManagementControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}