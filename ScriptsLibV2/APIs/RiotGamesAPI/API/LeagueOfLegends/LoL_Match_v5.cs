using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
	public partial class RiotGamesAPI
	{
		/// <summary>Get a list of match ids by puuid.</summary>
		public List<string> LoL_GetMatchIdsByPuuid(LoLRegion region, string puuid)
		{
			return MakeGETRequest<List<string>>(region, $"/lol/match/v5/matches/by-puuid/{puuid}/ids");
		}

		/// <summary>Get a match by match id.</summary>
		public MatchDTO LoL_GetMatchById(LoLRegion region, string matchId)
		{
			return MakeGETRequest<MatchDTO>(region, $"/lol/match/v5/matches/{matchId}");
		}

		/// <summary>Get a match timeline by match id.</summary>
		public MatchTimelineDTO LoL_GetMatchTimelineById(LoLRegion region, string matchId)
		{
			return MakeGETRequest<MatchTimelineDTO>(region, $"/lol/match/v5/matches/{matchId}/timeline");
		}
	}
}
