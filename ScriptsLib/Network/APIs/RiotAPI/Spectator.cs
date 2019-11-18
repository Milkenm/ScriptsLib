#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class Spectator // v4
		{
			/// <summary>Get current game information for the given summoner ID</summary>
			/// <param name="encryptedSummonerId">The ID of the summoner.</param>
			public static string GetCurrentGameInfo(string encryptedSummonerId)
			{
				return GET(ServerString() + $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}" + ApiString());
			}

			/// <summary>Get list of featured games.</summary>
			public static string GetFeaturedGames()
			{
				return GET(ServerString() + "/lol/spectator/v4/featured-games" + ApiString());
			}
		}
	}
}
