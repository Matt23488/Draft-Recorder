using DraftServiceLayer;
using DraftServiceLayer.Abstract;
using MtgDraftRecorder.ViewModels;
using System.Collections.Generic;

namespace MtgDraftRecorder.ModelBuilders
{
	public static class PlayerBuilder
	{
		public static Player BuildPlayerFromModel(PlayerModel model)
		{
			Player player = new Player();
			player.FirstName = model.FirstName;
			player.LastName = model.LastName;
			player.IsActive = true;
			return player;
		}

		public static IList<PlayerModel> BuildModelListFromPlayerList(IRepository repo)
		{
			IList<Player> players = repo.GetPlayers();

			IList<PlayerModel> model = new List<PlayerModel>();

			foreach(Player player in players)
			{
				int wins = repo.GetPlayerWinsFromPlayerId(player.PlayerId);
				model.Add(new PlayerModel { Id = player.PlayerId, FirstName = player.FirstName, LastName = player.LastName, Wins = wins});
			}

			return model;
		}
	}
}