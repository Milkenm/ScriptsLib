#region Usings
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
			public static string GetChampionMasteryList(string encryptedSummonerId) => GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + ApiString());

			/// <summary>Get a champion mastery by player ID and champion ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
			public static string GetMasteryByChampion(string encryptedSummonerId, long championId) => GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + ApiString());

			/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public static string GetTotalMasteryScore(string encryptedSummonerId) => GET(ServerString() + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + ApiString());
		}
	}
}
