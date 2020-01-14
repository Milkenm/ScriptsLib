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
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetChallengerEntries(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/tft/league/v1/challenger" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get league entries for a given summoner ID.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetSummonerLeagues(string encryptedSummonerId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/league/v1/entries/by-summoner/{encryptedSummonerId}" + ApiString());

				return ReturnResponse<LeagueEntryDTO[]>(request, getJsonObject);
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="page">Starts with page 1.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetLeagueEntries(Tiers tier, Divisions division, int? page, bool getJsonObject = false)
			{
				string requestString = ServerString() + $"/tft/league/v1/entries/{tier}/{division}" + ApiString();

				if (page != null)
				{
					requestString += "&page=" + page;
				}

				string request = GET(requestString);

				return ReturnResponse<LeagueEntryDTO>(request, getJsonObject);
			}

			/// <summary>Get the grandmaster league.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetGrandmasterEntries(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/tft/league/v1/grandmaster" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetLeagueById(int leagueId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/league/v1/leagues/{leagueId}" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get the master league.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetMasterEntries(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/tft/league/v1/master" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}
		}
	}
}
