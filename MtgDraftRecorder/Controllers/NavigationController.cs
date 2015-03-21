using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MtgDraftRecorder.Controllers
{
    public class NavigationController : Controller
    {
		public PartialViewResult Menu()
		{
			return PartialView();
		}
    }
}
