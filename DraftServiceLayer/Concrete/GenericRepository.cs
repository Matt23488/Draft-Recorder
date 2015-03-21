using DraftServiceLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DraftServiceLayer.Concrete
{
	public class GenericRepository : IRepository
	{
		public IList<Draft> GetDraftWinListFromPlayerId(int playerId)
		{
			IList<Draft> drafts = new List<Draft>();
			using(var context = new DraftEntities())
			{
				drafts = context.Drafts.Where(obj => obj.WinnerId == playerId).ToList();
			}

			return drafts;
		}

		public int GetPlayerWinsFromPlayerId(int playerId)
		{
			int wins = -1;
			using(var context = new DraftEntities())
			{
				wins = context.Drafts.Where(obj => obj.WinnerId == playerId).Count();
			}

			return wins;
		}

		public IList<string> GetSetAbbreviationsFromDraft(int draftId)
		{
			IList<string> sets = new List<string>();
			using(var context = new DraftEntities())
			{
				Draft draft = context.Drafts.SingleOrDefault(obj => obj.DraftId == draftId);
				sets.Add(draft.MagicSet1.SetAbbreviation);
				sets.Add(draft.MagicSet2.SetAbbreviation);
				sets.Add(draft.MagicSet3.SetAbbreviation);
			}

			return sets;
		}

		public string GetWinnerFromDraft(int draftId)
		{
			string winner = null;
			using(var context = new DraftEntities())
			{
				Player player = context.Drafts.SingleOrDefault(obj => obj.DraftId == draftId).Winner;
				winner = player.FirstName + " " + player.LastName;
			}

			return winner;
		}

		public IList<Draft> GetDrafts()
		{
			IList<Draft> draftList = null;
			using (var context = new DraftEntities())
			{
				draftList = context.Drafts.ToList();
			}
			if (draftList == null) throw new Exception("There was a problem getting draft list.");

			return draftList;
		}

		public Draft GetDraftById(int id)
		{
			Draft draft = null;
			using (var context = new DraftEntities())
			{
				draft = context.Drafts.FirstOrDefault(obj => obj.DraftId == id);
			}

			return draft;
		}

		public void AddDraft(Draft draft)
		{
			using (var context = new DraftEntities())
			{
				context.Drafts.Add(draft);
				context.SaveChanges();
			}
		}

		public IList<Player> GetPlayers()
		{
			IList<Player> playerList = null;
			using (var context = new DraftEntities())
			{
				playerList = context.Players.Where(obj => obj.IsActive).ToList();
			}
			if (playerList == null) throw new Exception("There was a problem getting player list.");

			return playerList;
		}

		public Player GetPlayerById(int id)
		{
			Player player = null;
			using (var context = new DraftEntities())
			{
				player = context.Players.FirstOrDefault(obj => obj.PlayerId == id);
			}

			return player;
		}

		public void AddPlayer(Player player)
		{
			using (var context = new DraftEntities())
			{
				context.Players.Add(player);
				context.SaveChanges();
			}
		}

		public void DeactivatePlayerById(int id)
		{
			using(var context = new DraftEntities())
			{
				context.Players.SingleOrDefault(obj => obj.PlayerId == id).IsActive = false;
				context.SaveChanges();
			}
		}

		public IList<Announcement> GetAnnouncements()
		{
			IList<Announcement> announcements = new List<Announcement>();
			using(var context = new DraftEntities())
			{
				announcements = context.Announcements.ToList();
			}

			return announcements;
		}

		public Announcement GetAnnouncementById(int id)
		{
			Announcement announcement;
			using(var context = new DraftEntities())
			{
				announcement = context.Announcements.SingleOrDefault(obj => obj.AnnouncementId == id);
			}

			return announcement;
		}

		public void AddAnnouncement(Announcement announcement)
		{
			using(var context = new DraftEntities())
			{
				context.Announcements.Add(announcement);
				context.SaveChanges();
			}
		}
	}
}