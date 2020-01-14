#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class TftSummoner // v1
		{
			/// <summary>Get a summoner by account ID.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetSummonerByAccountId(string encryptedAccountId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/summoner/v1/summoners/by-account/{encryptedAccountId}" + ApiString());

				return ReturnRequest<SummonerDTO>(request, getJsonObject);
			}

			/// <summary>Get a summoner by summoner name.</summary>
			/// <param name="summonerName">Summoner Name.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetSummonerByName(string summonerName, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/summoner/v1/summoners/by-name/{summonerName}" + ApiString());

				return ReturnRequest<SummonerDTO>(request, getJsonObject);
			}

			/// <summary>Get a summoner by PUUID.</summary>
			/// <param name="encryptedPUUID">Summoner ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetSummonerByPuuid(string encryptedPUUID, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/summoner/v1/summoners/by-puuid/{encryptedPUUID}" + ApiString());

				return ReturnRequest<SummonerDTO>(request, getJsonObject);
			}

			/// <summary>Get a summoner by summoner ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetSummonerBySummonerId(string encryptedSummonerId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/summoner/v1/summoners/{encryptedSummonerId}" + ApiString());

				return ReturnRequest<SummonerDTO>(request, getJsonObject);
			}
		}
	}
}
