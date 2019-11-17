#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class Summoner // v4
		{
			/// <summary>Get a summoner by account ID.</summary>
			public static string GetSummonerByAccountId(string encryptedAccountId) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-account/{encryptedAccountId}" + ApiString());

			/// <summary>Get a summoner by summoner name.</summary>
			/// <param name="summonerName">Summoner Name.</param>
			public static string GetSummonerByName(string summonerName) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-name/{summonerName}" + ApiString());

			/// <summary>Get a summoner by PUUID.</summary>
			/// <param name="encryptedPUUID">Summoner ID.</param>
			public static string GetSummonerByPuuid(string encryptedPUUID) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-puuid/{encryptedPUUID}" + ApiString());

			/// <summary>Get a summoner by summoner ID.</summary>
			/// <param name="encryptedSummonerId">Summoner ID.</param>
			public static string GetSummonerBySummonerId(string encryptedSummonerId) => GET(ServerString() + $"/lol/summoner/v4/summoners/{encryptedSummonerId}" + ApiString());
		}
	}
}
