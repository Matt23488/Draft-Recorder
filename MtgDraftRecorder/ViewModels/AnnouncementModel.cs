using System;

namespace MtgDraftRecorder.ViewModels
{
	public class AnnouncementModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string Creator { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}