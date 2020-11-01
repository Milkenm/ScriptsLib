using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class TftLeague // v1
		{
			/// <summary>Get the challenger league.</summary>
			public LeagueListDTO GetChallengerEntries(Regions region)
			{
				string request = GET(ServerString(region) + "/tft/league/v1/challenger" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get league entries for a given summoner ID.</summary>
			public LeagueEntryDTO[] GetSummonerLeagues(Regions region, string encryptedSummonerId)
			{
				string request = GET(ServerString(region) + $"/tft/league/v1/entries/by-summoner/{encryptedSummonerId}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueEntryDTO[]>(request);
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="page">Starts with page 1.</param>
			public LeagueEntryDTO GetLeagueEntries(Regions region, Tiers tier, Divisions division, int? page)
			{
				string requestString = ServerString(region) + $"/tft/league/v1/entries/{tier}/{division}" + ApiString();

				if (page != null)
				{
					requestString += "&page=" + page;
				}

				string request = GET(requestString);

				return JsonConvert.DeserializeObject<LeagueEntryDTO>(request);
			}

			/// <summary>Get the grandmaster league.</summary>
			public LeagueListDTO GetGrandmasterEntries(Regions region)
			{
				string request = GET(ServerString(region) + "/tft/league/v1/grandmaster" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			public LeagueListDTO GetLeagueById(Regions region, int leagueId)
			{
				string request = GET(ServerString(region) + $"/tft/league/v1/leagues/{leagueId}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}

			/// <summary>Get the master league.</summary>
			public LeagueListDTO GetMasterEntries(Regions region)
			{
				string request = GET(ServerString(region) + "/tft/league/v1/master" + ApiString());
				return JsonConvert.DeserializeObject<LeagueListDTO>(request);
			}
		}
	}
}
