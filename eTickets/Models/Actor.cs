using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }
		[Display(Name =" Profile Picture")]
		[Required(ErrorMessage ="Profile Micture is Required")]
		public string ProfilePictureURL { get; set; }
		[Display(Name = "Full Name")]
		[Required(ErrorMessage = "The Name is Required")]
		[StringLength(100, MinimumLength = 3, ErrorMessage ="The Name must me with 3 characters Minimum")]
		public string FullName { get; set; }
		[Display(Name = "Biography")]
		[Required(ErrorMessage = "Biography is Required")]
		public string  Bio { get; set; }

		// Relation
		public List<Actor_Movie> Actors_Movies { get; set; }
	}
}
