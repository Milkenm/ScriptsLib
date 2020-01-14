#region Usings
using System.Collections.Generic;

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
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetCurrentGameInfo(string encryptedSummonerId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}" + ApiString());

				return ReturnResponse<CurrentGameInfo>(request, getJsonObject);
			}

			/// <summary>Get list of featured games.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetFeaturedGames(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/lol/spectator/v4/featured-games" + ApiString());

				return ReturnResponse<FeaturedGames>(request, getJsonObject);
			}
		}
	}
}
