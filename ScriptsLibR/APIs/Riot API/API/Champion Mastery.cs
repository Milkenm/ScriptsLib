using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptsLibR.APIs.RiotAPI
{
    public partial class RiotAPI
    {
		public class ChampionMastery // v4
		{
			/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public List<ChampionMasteryDTO> GetChampionMasteryList(Region region, string encryptedSummonerId)
			{
				string request = GET(GetServerString(region) + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + GetAPIParameter());
				return JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(request);
			}

			/// <summary>Get a champion mastery by player ID and champion ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
			public ChampionMasteryDTO GetMasteryByChampion(Region region, string encryptedSummonerId, long championId)
			{
				string request = GET(GetServerString(region) + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + GetAPIParameter());
				return JsonConvert.DeserializeObject<ChampionMasteryDTO>(request);
			}

			/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
			/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
			public int GetTotalMasteryScore(Region region, string encryptedSummonerId)
			{
				return Convert.ToInt32(GET(GetServerString(region) + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + GetAPIParameter()));
			}
		}
	}
}
