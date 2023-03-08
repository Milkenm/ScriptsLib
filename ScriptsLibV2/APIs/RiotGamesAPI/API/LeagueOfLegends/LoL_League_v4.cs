﻿namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL League - v4
    public partial class RiotGamesAPI
    {
        /// <summary>Get the challenger league for given queue.</summary>
        public LeagueListDTO LoL_GetChallengerEntries(LoLRegion region, Queue queue)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, $"/lol/league/v4/challengerleagues/by-queue/{queue}");
        }

        /// <summary>Get league entries in all queues for a given summoner ID.</summary>
        public LeagueListDTO[] LoL_GetSummonerLeagues(LoLRegion region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<LeagueListDTO[]>(region, $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}");
        }

        /// <summary>Get all the league entries.</summary>
        /// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
        /// <param name="page">Starts with page 1.</param>
        public LeagueListDTO[] LoL_GetLeagueEntries(LoLRegion region, Queue queue, Tier tier, Division division, int? page)
        {
            string req = $"/lol/league/v4/entries/{queue}/{tier}/{division}";
            req += page != null ? $"&page={page}" : null;
            return this.MakeGETRequest<LeagueListDTO[]>(region, req);
        }

        /// <summary>Get the grandmaster league of a specific queue.</summary>
        public LeagueListDTO LoL_GetGrandmasterEntries(LoLRegion region, Queue queue)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, $"/lol/league/v4/grandmasterleagues/by-queue/{queue}");
        }

        /// <summary>Get league with given ID, including inactive entries.</summary>
        /// <param name="leagueId">The UUID of the league.</param>
        public LeagueListDTO LoL_GetLeagueById(LoLRegion region, int leagueId)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, $"/lol/league/v4/leagues/{leagueId}");
        }

        /// <summary>Get the master league for given queue.</summary>
        public LeagueListDTO LoL_GetMasterEntries(LoLRegion region, Queue queue)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, $"/lol/league/v4/masterleagues/by-queue/{queue}");
        }
    }
}