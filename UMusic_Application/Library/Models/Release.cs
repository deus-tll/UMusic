namespace Library.Models
{
	public enum ReleaseType
	{
		Album,
		Single,
		EP
	}


	public class Release : Collection
	{
		public DateTime ReleaseDate { get; set; }
		public ReleaseType Type { get; set; }
	}
}
