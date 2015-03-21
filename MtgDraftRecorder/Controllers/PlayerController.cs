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
    public class PlayerController : Controller
    {
		private IRepository repository;

		public PlayerController(IRepository repo)
		{
			repository = repo;
		}

		[HttpGet]
		public ViewResult List()
		{
			IList<PlayerModel> model = PlayerBuilder.BuildModelListFromPlayerList(repository);
			return View(model);
		}

        [HttpGet]
		public ViewResult Add()
		{
			return View();
		}

		[HttpPost]
		public ViewResult Add(PlayerModel model)
		{
			if (!ModelState.IsValid) return View(model);

			repository.AddPlayer(PlayerBuilder.BuildPlayerFromModel(model));

			return View("Success", model);
		}

		[HttpPost]
		[Authorize]
		public JsonResult Delete(int Id)
		{
			string message = "RESULT_OK";

			try
			{
				repository.DeactivatePlayerById(Id);
			}
			catch(Exception e)
			{
				message = e.Message;
			}

			return Json(message);
		}
    }
}
