using System.Collections.Generic;

namespace ScriptsLibV2.APIs
{
    /// LoL Match - v4
    public partial class RiotAPI
    {
        /// <summary>Get match by match ID.</summary>
        public MatchDTO LoL_GetMatchById(Region region, long matchId)
        {
            return this.MakeGETRequest<MatchDTO>(region, $"/lol/match/v4/matches/{matchId}");
        }

        /// <summary>Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any.</summary>
        /// <param name="encryptedAccountId">The account ID.</param>
        /// <param name="champion">Set of champion IDs for filtering the matchlist.</param>
        /// <param name="queue">Set of queue IDs for filtering the matchlist.</param>
        /// <param name="endTime">The end time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
        /// <param name="beginTime">The begin time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
        /// <param name="endIndex">The end index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
        /// <param name="beginIndex">The begin index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
        public MatchlistDTO LoL_GetMatchHistory(Region region, string encryptedAccountId, int?[] champion, int?[] queue, long? endTime, long? beginTime, int? endIndex, int? beginIndex)
        {
            string req = $"/lol/match/v4/matchlists/by-account/{encryptedAccountId}";
            req += champion.Length > 0 ? $"&champion={string.Join("&champion=", champion)}" : null;
            req += queue.Length > 0 ? $"&queue={string.Join("&queue=", queue)}" : null;
            req += endTime != null ? $"&endTime={endTime}" : null;
            req += beginTime != null ? $"&beginTime={beginTime}" : null;
            req += endIndex != null ? $"&endIndex={endIndex}" : null;
            req += beginIndex != null ? $"&beginIndex={beginIndex}" : null;
            return this.MakeGETRequest<MatchlistDTO>(region, req);
        }

        /// <summary>Get match timeline by match ID.</summary>
        /// <param name="matchId">The match ID.</param>
        public MatchTimelineDTO LoL_GetMatchTimeline(Region region, long matchId)
        {
            return this.MakeGETRequest<MatchTimelineDTO>(region, $"/lol/match/v4/timelines/by-match/{matchId}");
        }

        /// <summary>Get match IDs by tournament code.</summary>
        /// <param name="tournamentCode">The tournament code.</param>
        public List<long> LoL_GetMatchIdByTournamentCode(Region region, string tournamentCode)
        {
            return this.MakeGETRequest<List<long>>(region, $"/lol/match/v4/matches/by-tournament-code/{tournamentCode}/ids");
        }

        /// <summary>Get match by match ID and tournament code.</summary>
        /// <param name="tournamentCode">The tournament code.</param>
        /// <param name="matchId">The match ID.</param>
        public MatchDTO LoL_GetMatchByIdAndTournamentCode(Region region, string tournamentCode, long matchId)
        {
            return this.MakeGETRequest<MatchDTO>(region, $"/lol/match/v4/matches/{matchId}/by-tournament-code/{tournamentCode}");
        }
    }
}
