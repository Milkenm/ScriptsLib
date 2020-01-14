#region Usings
using System.Collections.Generic;

using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class League // v4
		{
			/// <summary>Get the challenger league for given queue.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetChallengerEntries(Queues queue, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league/v4/challengerleagues/by-queue/{queue}" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get league entries in all queues for a given summoner ID.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetSummonerLeagues(string encryptedSummonerId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}" + ApiString());

				return ReturnResponse<LeagueEntryDTO[]>(request, getJsonObject);
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			/// <param name="page">Starts with page 1.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetLeagueEntries(Queues queue, Tiers tier, Divisions division, int? page, bool getJsonObject = false)
			{
				string requestString = ServerString() + $"/lol/league/v4/entries/{queue}/{tier}/{division}" + ApiString();

				if (page != null)
				{
					requestString += "&page=" + page;
				}

				string request = GET(requestString);

				return ReturnResponse<LeagueListDTO[]>(request, getJsonObject);
			}

			/// <summary>Get the grandmaster league of a specific queue.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetGrandmasterEntries(Queues queue, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league/v4/grandmasterleagues/by-queue/{queue}" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetLeagueById(int leagueId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league/v4/leagues/{leagueId}" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}

			/// <summary>Get the master league for given queue.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMasterEntries(Queues queue, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league/v4/masterleagues/by-queue/{queue}" + ApiString());

				return ReturnResponse<LeagueListDTO>(request, getJsonObject);
			}
		}
	}
}
