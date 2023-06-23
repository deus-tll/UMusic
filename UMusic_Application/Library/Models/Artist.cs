namespace Library.Models
{
	public class Artist : User
	{
		public int Followers { get; set; }
		public int MonthlyListeners { get; set; }
		public int Songs { get; set; }
		public int Albums { get; set; }
		public int Singles { get; set; }
		public int EPs { get; set; }
	}
}
