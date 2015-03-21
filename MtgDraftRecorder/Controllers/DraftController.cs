using DraftServiceLayer.Abstract;
using MtgDraftRecorder.ModelBuilders;
using MtgDraftRecorder.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MtgDraftRecorder.Controllers
{
    public class DraftController : Controller
    {
		private IRepository repository;

		public DraftController(IRepository repo)
		{
			repository = repo;
		}

        [HttpGet]
		public ViewResult History()
		{
			IList<DraftModel> model = DraftBuilder.BuildModelListFromDraftList(repository.GetDrafts());
			return View(model);
		}

		[HttpPost]
		//[ActionName("WonDrafts")]
		public ActionResult WonDraftsByPlayerId(PlayerModel player)
		{
			IList<DraftModel> model =  DraftBuilder.GetDraftWinListFromPlayerId(player.Id);
			return PartialView(model);
		}

		//[HttpGet]
		//public ViewResult Start()
		//{

		//}
    }
}
