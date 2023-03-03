using System.Collections.Generic;

using Newtonsoft.Json;

namespace ScriptsLibV2.APIs.RiotGames
{
	/// LoL Champion Mastery - v4
	public partial class RiotGamesAPI
	{
		/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
		/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
		public List<ChampionMasteryDTO> LoL_GetChampionMasteryList(LoLRegion region, string encryptedSummonerId)
		{
			return MakeGETRequest<List<ChampionMasteryDTO>>(region, $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}");
		}

		/// <summary>Get a champion mastery by player ID and champion ID.</summary>
		/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
		/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
		public ChampionMasteryDTO LoL_GetMasteryByChampion(LoLRegion region, string encryptedSummonerId, long championId)
		{
			return MakeGETRequest<ChampionMasteryDTO>(region, $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}");
		}

		/// <summary>Get specified number of top champion mastery entries sorted by number of champion points descending.</summary>
		public List<ChampionMasteryDTO> LoL_GetTopChampionMasteryList(LoLRegion region, string encryptedSummonerId)
		{
			return MakeGETRequest<List<ChampionMasteryDTO>>(region, $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/top");
		}

		/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
		/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
		public int LoL_GetTotalMasteryScore(LoLRegion region, string encryptedSummonerId)
		{
			return MakeGETRequest<int>(region, $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}");
		}
	}

	/// <summary>This object contains single Champion Mastery information for player and champion combination.</summary>
	public class ChampionMasteryDTO
	{
		/// <summary>Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.</summary>
		[JsonProperty("championPointsUntilNextLevel")] public long ChampionPointsUntilNextLevel;
		/// <summary>Is chest granted for this champion or not in current season.</summary>
		[JsonProperty("chestGranted")] public bool IsChestGranted;
		/// <summary>Champion ID for this entry.</summary>
		[JsonProperty("championId")] public long ChampionId;
		/// <summary>Last time this champion was played by this player - in Unix milliseconds time format.</summary>
		[JsonProperty("lastPlayTime")] public long LastPlayTime;
		/// <summary>Champion level for specified player and champion combination.</summary>
		[JsonProperty("championLevel")] public int ChampionLevel;
		/// <summary>Summoner ID for this entry. (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;
		/// <summary>Total number of champion points for this player and champion combination - they are used to determine championLevel.</summary>
		[JsonProperty("championPoints")] public int ChampionPoints;
		/// <summary>Number of points earned since current level has been achieved.</summary>
		[JsonProperty("championPointsSinceLastLevel")] public long ChampionPointsSinceLastLevel;
		/// <summary>The token earned for this champion to levelup.</summary>
		[JsonProperty("tokensEarned")] public int TokensEarned;
	}
}
