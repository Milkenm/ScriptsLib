#region Usings
using Newtonsoft.Json;
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class LeagueExp
		{
			#region JSON
			public class LeagueEntryDTO
			{
				public string queueType;
				public string summonerName;
				public bool hotStreak;
				public MiniSeriesDTO miniSeries;
				/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
				public int wins;
				public bool veteran;
				/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
				public int losses;
				public string rank;
				public string leagueId;
				public bool inactive;
				public bool freshBlood;
				public string tier;
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





			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetLeagueEntries(string queue, string tier, string division, bool getJsonObject)
			{
				string request = GET(ServerString() + $"/lol/league-exp/v4/entries/{queue}/{tier}/{division}" + ApiString());

				if (getJsonObject)
				{
					return JsonConvert.DeserializeObject<LeagueEntryDTO>(request);
				}
				return request;
			}
		}
	}
}
