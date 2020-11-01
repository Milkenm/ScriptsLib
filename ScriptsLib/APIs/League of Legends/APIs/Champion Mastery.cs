using Newtonsoft.Json;

using System;
using System.Collections.Generic;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class ChampionMastery // v4
		{
			/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public List<ChampionMasteryDTO> GetChampionMasteryList(Regions region, string encryptedSummonerId)
			{
				string request = GET(ServerString(region) + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + ApiString());
				return JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(request);
			}

			/// <summary>Get a champion mastery by player ID and champion ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
			public ChampionMasteryDTO GetMasteryByChampion(Regions region, string encryptedSummonerId, long championId)
			{
				string request = GET(ServerString(region) + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + ApiString());
				return JsonConvert.DeserializeObject<ChampionMasteryDTO>(request);
			}

			/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public int GetTotalMasteryScore(Regions region, string encryptedSummonerId)
			{
				return Convert.ToInt32(GET(ServerString(region) + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + ApiString()));
			}
		}
	}
}