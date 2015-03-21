using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MtgDraftRecorder.Controllers
{
    public class ErrorController : Controller
    {
		[HttpGet]
		public ViewResult PageNotFound()
		{
			return View();
		}

		[HttpGet]
		public ViewResult AccessDenied()
		{
			return View();
		}
    }
}
