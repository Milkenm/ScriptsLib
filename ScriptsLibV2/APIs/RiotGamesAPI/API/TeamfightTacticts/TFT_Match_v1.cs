using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
	/// TFT Match - v1
	public partial class RiotGamesAPI
	{
		/// <summary>Get a list of match ids by PUUID.</summary>
		public List<string> GetMatchIds(LoLRegion region, string encryptedPuuid)
		{
			return MakeGETRequest<List<string>>(region, $"/tft/match/v1/matches/by-puuid/{encryptedPuuid}/ids");
		}

		/// <summary>Get a match by match id.</summary>
		public MatchDTO GetMatchById(LoLRegion region, string matchId)
		{
			return MakeGETRequest<MatchDTO>(region, $"/tft/match/v1/matches/{matchId}");
		}
	}
}
