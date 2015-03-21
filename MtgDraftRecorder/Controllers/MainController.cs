using SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MtgDraftRecorder.Controllers
{
    public class MainController : Controller
    {
		[HttpGet]
		public ViewResult About()
		{
			return View();
		}

		[HttpPost]
		public JsonResult Login(string Username, string Password)
		{
			string message = "Invalid Username or Password";

			bool result = FormsAuthentication.Authenticate(Username, Password);
			if(result)
			{
				FormsAuthentication.SetAuthCookie(Username, true);
				message = "RESULT_OK";
			}

			return Json(message);
		}

		[HttpPost]
		public JsonResult Logout()
		{
			string message = "RESULT_OK";
			try
			{
				FormsAuthentication.SignOut();
			}
			catch(Exception e)
			{
				message = e.Message;
			}
			return Json(message);
		}

		// Temporary
		[HttpPost]
		public JsonResult TestConnection()
		{
			string result = "RESULT_OK";
			ServerMain smsServer = new ServerMain();
			try
			{
				if(!smsServer.TestConnection())
				{
					result = "Timed out";
				}
			}
			catch (Exception ex)
			{
				result = "Exception:<br />" + ex.InnerException;
			}

			return Json(result);
		}
    }
}
