using DraftServiceLayer.Abstract;
using MtgDraftRecorder.ModelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MtgDraftRecorder.Controllers
{
    public class AnnouncementController : Controller
    {
		private IRepository repo;

		public AnnouncementController(IRepository repository)
		{
			repo = repository;
		}
        public PartialViewResult Banner()
		{
			return PartialView(AnnouncementBuilder.BuildModelListFromAnnouncementList(repo.GetAnnouncements()));
		}

    }
}
