namespace Library.Models
{
	public class Collection
	{
		public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public DateTime DateOfAddition { get; set; }
		public int Songs { get; set; }
		public int Duration { get; set; }
		public string? CoverImageLink { get; set; }
	}
}
