using System.Collections.Generic;

namespace ScriptsLibR.APIs.RiotAPI
{
	/// LoL Challenges - v1
	public partial class RiotAPI
	{
		/// <summary>List of all basic challenge configuration information (includes all translations for names and descriptions).</summary>
		public List<ChallengeConfigInfoDto> LoL_GetChallengesConfig(Region region)
		{
			return this.MakeGETRequest<List<ChallengeConfigInfoDto>>(region, "/lol/challenges/v1/challenges/config");
		}

		/// <summary>Map of level to percentile of players who have achieved it - keys: ChallengeId -> Season -> Level -> percentile of players who achieved it.</summary>
		public Dictionary<long, Dictionary<int, Dictionary<int, double>>> LoL_GetChallengesPercentiles(Region region)
		{
			return this.MakeGETRequest<Dictionary<long, Dictionary<int, Dictionary<int, double>>>>(region, "/lol/challenges/v1/challenges/percentiles");
		}

		/// <summary>Get challenge configuration (REST).</summary>
		public ChallengeConfigInfoDto LoL_GetChallengesConfig(Region region, long challengeId)
		{
			return this.MakeGETRequest<ChallengeConfigInfoDto>(region, $"/lol/challenges/v1/challenges/{challengeId}/config");
		}

		/// <summary>Return top players for each level. Level must be MASTER, GRANDMASTER or CHALLENGER.</summary>
		public List<ApexPlayerInfoDto> LoL_GetChallengesLeaderboardsByLevel(Region region, string level, long challengeId)
		{
			return this.MakeGETRequest<List<ApexPlayerInfoDto>>(region, $"/lol/challenges/v1/challenges/{challengeId}/leaderboards/by-level/{level}");
		}
	}
}

