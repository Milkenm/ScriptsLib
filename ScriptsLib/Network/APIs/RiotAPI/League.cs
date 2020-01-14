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
			#region JSON
			public class LeagueListDTO
			{
				public string leagueId;
				public string tier;
				public List<LeagueItemDTO> entries;
				public string queue;
				public string name;
			}

			public class LeagueItemDTO
			{
				public string summonerName;
				public bool hotStreak;
				public MiniSeriesDTO miniSeries;
				/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
				public int wins;
				public bool veteran;
				/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
				public int losses;
				public bool freshBlood;
				public bool inactive;
				public string rank;
				/// <summary>Player's summonerId (Encrypted)</summary>
				public string summonerId;
				public int leaguePoints;
			}

			public class MiniSeriesDTO
			{
				public string progress;
				public int losses;
				public int target;
				public int wins;
			}
			#endregion JSON





			/// <summary>Get the challenger league for given queue.</summary>
			public static string GetChallengerEntries(Queues queue)
			{
				return GET(ServerString() + $"/lol/league/v4/challengerleagues/by-queue/{queue}" + ApiString());
			}

			/// <summary>Get league entries in all queues for a given summoner ID.</summary>
			public static string GetSummonerLeagues(string encryptedSummonerId)
			{
				return GET(ServerString() + $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}" + ApiString());
			}

			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			/// <param name="page">Starts with page 1.</param>
			public static string GetLeagueEntries(Queues queue, Tiers tier, Divisions division, int? page)
			{
				string request = ServerString() + $"/lol/league/v4/entries/{queue}/{tier}/{division}" + ApiString();

				if (page != null)
				{
					request += "&page=" + page;
				}

				return GET(request);
			}

			/// <summary>Get the grandmaster league of a specific queue.</summary>
			public static string GetGrandmasterEntries(Queues queue)
			{
				return GET(ServerString() + $"/lol/league/v4/grandmasterleagues/by-queue/{queue}" + ApiString());
			}

			/// <summary>Get league with given ID, including inactive entries.</summary>
			/// <param name="leagueId">The UUID of the league.</param>
			public static string GetLeagueById(int leagueId)
			{
				return GET(ServerString() + $"/lol/league/v4/leagues/{leagueId}" + ApiString());
			}

			/// <summary>Get the master league for given queue.</summary>
			public static string GetMasterEntries(Queues queue)
			{
				return GET(ServerString() + $"/lol/league/v4/masterleagues/by-queue/{queue}" + ApiString());
			}
		}
	}
}
