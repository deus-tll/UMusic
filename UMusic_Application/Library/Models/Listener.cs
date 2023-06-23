namespace Library.Models
{
	public class Listener : User
	{
		public int LikedSongsCollectionId { get; set; }
		public DateTime LastLoginDate { get; set; }
		public int PublicPlaylists { get; set; }
		public int Following { get; set; }
	}
}
