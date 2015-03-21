using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftServiceLayer.Abstract
{
	public interface IPlayerRepository
	{
		IList<Player> GetPlayers();
		Player GetPlayerById(int id);
		void AddPlayer(Player player);
	}
}
