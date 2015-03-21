using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftServiceLayer.Abstract
{
	public interface IRepository
	{
		#region dbo.Drafts
		IList<Draft> GetDrafts();
		Draft GetDraftById(int id);
		void AddDraft(Draft draft);
		IList<string> GetSetAbbreviationsFromDraft(int draftId);
		string GetWinnerFromDraft(int draftId);
		#endregion

		#region dbo.Players
		IList<Player> GetPlayers();
		Player GetPlayerById(int id);
		void AddPlayer(Player player);
		void DeactivatePlayerById(int id);
		IList<Draft> GetDraftWinListFromPlayerId(int playerId);
		int GetPlayerWinsFromPlayerId(int playerId);
		#endregion

		#region dbo.Announcements
		IList<Announcement> GetAnnouncements();
		Announcement GetAnnouncementById(int id);
		void AddAnnouncement(Announcement announcement);
		#endregion
	}
}
