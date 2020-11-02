using Newtonsoft.Json;

using System.Collections.Generic;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class TftMatch // v1
		{
			/// <summary>Get a list of match ids by PUUID.</summary>
			public List<string> GetMatchIds(Regions region, string encryptedPUUID)
			{
				string request = GET(ServerString(region) + $"/tft/match/v1/matches/by-puuid/{encryptedPUUID}/ids" + ApiString());
				return JsonConvert.DeserializeObject<List<string>>(request);
			}

			/// <summary>Get a match by match id.</summary>
			public MatchDTO GetMatchById(Regions region, string matchId)
			{
				string request = GET(ServerString(region) + $"/tft/match/v1/matches/{matchId}" + ApiString());
				return JsonConvert.DeserializeObject<MatchDTO>(request);
			}
		}
	}
}