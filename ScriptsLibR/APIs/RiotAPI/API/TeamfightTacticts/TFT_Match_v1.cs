using System.Collections.Generic;

namespace ScriptsLibR.APIs.RiotAPI
{
    /// TFT Match - v1
    public partial class RiotAPI
    {
        /// <summary>Get a list of match ids by PUUID.</summary>
        public List<string> GetMatchIds(Region region, string encryptedPUUID)
        {
            return this.MakeGETRequest<List<string>>(region, $"/tft/match/v1/matches/by-puuid/{encryptedPUUID}/ids");
        }

        /// <summary>Get a match by match id.</summary>
        public MatchDTO GetMatchById(Region region, string matchId)
        {
            return this.MakeGETRequest<MatchDTO>(region, $"/tft/match/v1/matches/{matchId}");
        }
    }
}
