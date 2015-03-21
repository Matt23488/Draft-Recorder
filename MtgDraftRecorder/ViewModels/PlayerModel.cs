using System.ComponentModel.DataAnnotations;

namespace MtgDraftRecorder.ViewModels
{
	public class PlayerModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "You must enter a first name!")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "You must enter a last name!")]
		public string LastName { get; set; }

		public int Wins { get; set; }
	}
}