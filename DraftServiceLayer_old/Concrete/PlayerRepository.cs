using DraftServiceLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftServiceLayer.Concrete
{
	public class PlayerRepository : IPlayerRepository
	{
		public IList<Player> GetPlayers()
		{
			IList<Player> playerList = null;
			using (var context = new DraftEntities())
			{
				playerList = context.Players.ToList();
			}
			if (playerList == null) throw new Exception("There was a problem getting player list.");

			return playerList;
		}

		public Player GetPlayerById(int id)
		{
			Player player = null;
			using(var context = new DraftEntities())
			{
				player = context.Players.FirstOrDefault(obj => obj.PlayerId == id);
			}

			return player;
		}

		public void AddPlayer(Player player)
		{
			using(var context = new DraftEntities())
			{
				context.Players.Add(player);
				context.SaveChanges();
			}
		}
	}
}
