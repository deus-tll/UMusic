namespace Library.Models
{
	public class User
	{
		public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Nickname { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public DateTime RegistrationDate { get; set; }
		public string? AvatarLink { get; set; }
	}
}
