using DraftServiceLayer;
using DraftServiceLayer.Abstract;
using DraftServiceLayer.Concrete;
using MtgDraftRecorder.ViewModels;
using System.Collections.Generic;

namespace MtgDraftRecorder.ModelBuilders
{
	public static class AnnouncementBuilder
	{
		public static IList<AnnouncementModel> BuildModelListFromAnnouncementList(IList<Announcement> announcements)
		{
			IList<AnnouncementModel> model = new List<AnnouncementModel>();
			IRepository repo = new GenericRepository();

			foreach(Announcement announcement in announcements)
			{
				Player creator = repo.GetPlayerById(announcement.CreatedById);
				model.Add(new AnnouncementModel
				{
					Id = announcement.AnnouncementId,
					Title = announcement.Title,
					Content = announcement.Content,
					Creator = creator.FirstName + " " + creator.LastName,
					CreatedDate = announcement.CreatedDate
				});
			}

			return model;
		}
	}
}