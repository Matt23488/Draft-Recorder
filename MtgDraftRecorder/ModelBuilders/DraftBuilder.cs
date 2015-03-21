using DraftServiceLayer;
using DraftServiceLayer.Abstract;
using DraftServiceLayer.Concrete;
using MtgDraftRecorder.ViewModels;
using System.Collections.Generic;

namespace MtgDraftRecorder.ModelBuilders
{
	public static class DraftBuilder
	{
		public static IList<DraftModel> BuildModelListFromDraftList(IList<Draft> drafts)
		{
			IList<DraftModel> model = new List<DraftModel>();
			IRepository repo = new GenericRepository();

			foreach(Draft draft in drafts)
			{
				IList<string> sets = repo.GetSetAbbreviationsFromDraft(draft.DraftId);
				model.Add(new DraftModel
				{
					Id = draft.DraftId,
					DraftDate = draft.DraftDate,
					Set1 = sets[0],
					Set2 = sets[1],
					Set3 = sets[2],
					Winner = repo.GetWinnerFromDraft(draft.DraftId)
				});
			}

			return model;
		}

		public static IList<DraftModel> GetDraftWinListFromPlayerId(int playerId)
		{
			GenericRepository repo = new GenericRepository();
			IList<Draft> wonDrafts = repo.GetDraftWinListFromPlayerId(playerId);
			IList<DraftModel> model = new List<DraftModel>();
			foreach(Draft draft in wonDrafts)
			{
				IList<string> sets = repo.GetSetAbbreviationsFromDraft(draft.DraftId);
				model.Add(new DraftModel
				{
					Id = draft.DraftId,
					DraftDate = draft.DraftDate,
					Set1 = sets[0],
					Set2 = sets[1],
					Set3 = sets[2],
					Winner = repo.GetWinnerFromDraft(draft.DraftId)
				});
			}

			return model;
		}
	}
}