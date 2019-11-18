#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class TftLeague // v1
		{
			/// <summary>Get the challenger league.</summary>
			public static string GetChallengerEntries()
			{
				return GET(ServerString() + "/tft/league/v1/challenger" + ApiString());
			}

			/// <summary>Get league entries for a given summoner ID.</summary>
			public static string GetSummonerLeagues(string encryptedSummonerId)
			{
				return GET(ServerString() + $"/tft/league/v1/entries/by-summoner/{encryptedSummonerId}" + ApiString());
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="page">Starts with page 1.</param>
			public static string GetLeagueEntries(Tiers tier, Divisions division, int? page)
			{
				string request = ServerString() + $"/tft/league/v1/entries/{tier}/{division}" + ApiString();

				if (page != null)
				{
					request += "&page=" + page;
				}

				return request;
			}

			/// <summary>Get the grandmaster league.</summary>
			public static string GetGrandmasterEntries()
			{
				return GET(ServerString() + "/tft/league/v1/grandmaster" + ApiString());
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			public static string GetLeagueById(int leagueId)
			{
				return GET(ServerString() + $"/tft/league/v1/leagues/{leagueId}" + ApiString());
			}

			/// <summary>Get the master league.</summary>
			public static string GetMasterEntries()
			{
				return GET(ServerString() + "/tft/league/v1/master" + ApiString());
			}
		}
	}
}
