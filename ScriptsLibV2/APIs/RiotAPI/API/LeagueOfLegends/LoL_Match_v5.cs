using System.Collections.Generic;

namespace ScriptsLibV2.APIs
{
	public partial class RiotAPI
	{
		/// <summary>Get a list of match ids by puuid.</summary>
		public List<string> LoL_GetMatchIdsByPuuid(Region region, string puuid)
		{
			return MakeGETRequest<List<string>>(region, $"/lol/match/v5/matches/by-puuid/{puuid}/ids");
		}

		/// <summary>Get a match by match id.</summary>
		public MatchDTO LoL_GetMatchById(Region region, string matchId)
		{
			return MakeGETRequest<MatchDTO>(region, $"/lol/match/v5/matches/{matchId}");
		}

		/// <summary>Get a match timeline by match id.</summary>
		public MatchTimelineDTO LoL_GetMatchTimelineById(Region region, string matchId)
		{
			return MakeGETRequest<MatchTimelineDTO>(region, $"/lol/match/v5/matches/{matchId}/timeline");
		}
	}
}
