using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class Summoner // v4
		{
			/// <summary>Get a summoner by account ID.</summary>
			public SummonerDTO GetSummonerByAccountId(Regions region, string encryptedAccountId)
			{
				string request = GET(ServerString(region) + $"/lol/summoner/v4/summoners/by-account/{encryptedAccountId}" + ApiString());
				return JsonConvert.DeserializeObject<SummonerDTO>(request);
			}

			/// <summary>Get a summoner by summoner name.</summary>
			/// <param name="summonerName">Summoner Name.</param>
			public SummonerDTO GetSummonerByName(Regions region, string summonerName)
			{
				string request = GET(ServerString(region) + $"/lol/summoner/v4/summoners/by-name/{summonerName}" + ApiString());
				return JsonConvert.DeserializeObject<SummonerDTO>(request);
			}

			/// <summary>Get a summoner by PUUID.</summary>
			/// <param name="encryptedPUUID">Summoner ID.</param>
			public SummonerDTO GetSummonerByPuuid(Regions region, string encryptedPUUID)
			{
				string request = GET(ServerString(region) + $"/lol/summoner/v4/summoners/by-puuid/{encryptedPUUID}" + ApiString());
				return JsonConvert.DeserializeObject<SummonerDTO>(request);
			}

			/// <summary>Get a summoner by summoner ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID.</param>
			public SummonerDTO GetSummonerBySummonerId(Regions region, string encryptedSummonerId)
			{
				string request = GET(ServerString(region) + $"/lol/summoner/v4/summoners/{encryptedSummonerId}" + ApiString());
				return JsonConvert.DeserializeObject<SummonerDTO>(request);
			}
		}
	}
}