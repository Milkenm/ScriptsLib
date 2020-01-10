#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class ChampionMastery // v4
		{
			#region JSON
			/// <summary>This object contains single Champion Mastery information for player and champion combination.</summary>
			public class ChampionMasteryDTO
			{
				/// <summary>Is chest granted for this champion or not in current season.</summary>
				public bool chestGranted;
				/// <summary>Champion level for specified player and champion combination.</summary>
				public int championLevel;
				/// <summary>Total number of champion points for this player and champion combination - they are used to determine championLevel.</summary>
				public int championPoints;
				/// <summary>Champion ID for this entry.</summary>
				public long championId;
				/// <summary>Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.</summary>
				public long championPointsUntilNextLevel;
				/// <summary>Last time this champion was played by this player - in Unix milliseconds time format.</summary>
				public long lastPlayTime;
				/// <summary>The token earned for this champion to levelup.</summary>
				public int tokensEarned;
				/// <summary>Number of points earned since current level has been achieved.</summary>
				public long championPointsSinceLastLevel;
				/// <summary>Summoner ID for this entry. (Encrypted)</summary>
				public string summonerId;
			}
			#endregion JSON





			/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public static string GetChampionMasteryList(string encryptedSummonerId)
			{
				return GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + ApiString());
			}

			/// <summary>Get a champion mastery by player ID and champion ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
			public static string GetMasteryByChampion(string encryptedSummonerId, long championId)
			{
				return GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + ApiString());
			}

			/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public static string GetTotalMasteryScore(string encryptedSummonerId)
			{
				return GET(ServerString() + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + ApiString());
			}
		}
	}
}
