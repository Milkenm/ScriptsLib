#region Usings
using System;
using System.Collections.Generic;

using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class ChampionMastery // v4
		{
			/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetChampionMasteryList(string encryptedSummonerId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + ApiString());

				return ReturnRequest<List<ChampionMasteryDTO>>(request, getJsonObject);
			}

			/// <summary>Get a champion mastery by player ID and champion ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMasteryByChampion(string encryptedSummonerId, long championId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + ApiString());

				return ReturnRequest<ChampionMasteryDTO>(request, getJsonObject);
			}

			/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public static int GetTotalMasteryScore(string encryptedSummonerId)
			{
				return Convert.ToInt32(GET(ServerString() + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + ApiString()));
			}
		}
	}
}