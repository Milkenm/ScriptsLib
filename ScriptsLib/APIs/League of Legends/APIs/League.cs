using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class League // v4
		{
			/// <summary>Get the challenger league for given queue.</summary>
			public LeagueListDTO GetChallengerEntries(Regions region, Queues queue)
			{
				string request = GET(ServerString(region) + $"/lol/league/v4/challengerleagues/by-queue/{queue}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get league entries in all queues for a given summoner ID.</summary>
			public LeagueListDTO[] GetSummonerLeagues(Regions region, string encryptedSummonerId)
			{
				string request = GET(ServerString(region) + $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO[]>(request);
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			/// <param name="page">Starts with page 1.</param>
			public LeagueListDTO[] GetLeagueEntries(Regions region, Queues queue, Tiers tier, Divisions division, int? page)
			{
				string requestString = ServerString(region) + $"/lol/league/v4/entries/{queue}/{tier}/{division}" + ApiString();

				if (page != null)
				{
					requestString += "&page=" + page;
				}

				string request = GET(requestString);
				return JsonConvert.DeserializeObject<LeagueListDTO[]>(request);
			}

			/// <summary>Get the grandmaster league of a specific queue.</summary>
			public LeagueListDTO GetGrandmasterEntries(Regions region, Queues queue)
			{
				string request = GET(ServerString(region) + $"/lol/league/v4/grandmasterleagues/by-queue/{queue}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			public LeagueListDTO GetLeagueById(Regions region, int leagueId)
			{
				string request = GET(ServerString(region) + $"/lol/league/v4/leagues/{leagueId}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get the master league for given queue.</summary>
			public LeagueListDTO GetMasterEntries(Regions region, Queues queue)
			{
				string request = GET(ServerString(region) + $"/lol/league/v4/masterleagues/by-queue/{queue}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}
		}
	}
}
