using System;

namespace MtgDraftRecorder.ViewModels
{
	public class DraftModel
	{
		public int Id { get; set; }
		public DateTime DraftDate { get; set; }
		public string Set1 { get; set; }
		public string Set2 { get; set; }
		public string Set3 { get; set; }
		public string Winner { get; set; }
	}
}