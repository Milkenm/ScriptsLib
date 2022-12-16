using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
	/// LoL Challenges - v1
	public partial class RiotGamesAPI
	{
		/// <summary>List of all basic challenge configuration information (includes all translations for names and descriptions).</summary>
		public List<ChallengeConfigInfoDTO> LoL_GetChallengesConfig(LoLRegion region)
		{
			return MakeGETRequest<List<ChallengeConfigInfoDTO>>(region, "/lol/challenges/v1/challenges/config");
		}

		/// <summary>Map of level to percentile of players who have achieved it - keys: ChallengeId -> Season -> Level -> percentile of players who achieved it.</summary>
		public Dictionary<long, Dictionary<int, Dictionary<int, double>>> LoL_GetChallengesPercentiles(LoLRegion region)
		{
			return MakeGETRequest<Dictionary<long, Dictionary<int, Dictionary<int, double>>>>(region, "/lol/challenges/v1/challenges/percentiles");
		}

		/// <summary>Get challenge configuration (REST).</summary>
		public ChallengeConfigInfoDTO LoL_GetChallengesConfig(LoLRegion region, long challengeId)
		{
			return MakeGETRequest<ChallengeConfigInfoDTO>(region, $"/lol/challenges/v1/challenges/{challengeId}/config");
		}

		/// <summary>Return top players for each level. Level must be MASTER, GRANDMASTER or CHALLENGER.</summary>
		public List<ApexPlayerInfoDTO> LoL_GetChallengesLeaderboardsByLevel(LoLRegion region, string level, long challengeId)
		{
			return MakeGETRequest<List<ApexPlayerInfoDTO>>(region, $"/lol/challenges/v1/challenges/{challengeId}/leaderboards/by-level/{level}");
		}
	}
}

