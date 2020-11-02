using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class Spectator // v4
		{
			/// <summary>Get current game information for the given summoner ID</summary>
			/// <param name="encryptedSummonerId">The ID of the summoner.</param>
			public CurrentGameInfo GetCurrentGameInfo(Regions region, string encryptedSummonerId)
			{
				string request = GET(ServerString(region) + $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}" + ApiString());
				return JsonConvert.DeserializeObject<CurrentGameInfo>(request);
			}

			/// <summary>Get list of featured games.</summary>
			public FeaturedGames GetFeaturedGames(Regions region)
			{
				string request = GET(ServerString(region) + "/lol/spectator/v4/featured-games" + ApiString());
				return JsonConvert.DeserializeObject<FeaturedGames>(request);
			}
		}
	}
}