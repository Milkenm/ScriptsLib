namespace ScriptsLibV2.APIs.RiotGames
{
    /// TFT League - v1
    public partial class RiotGamesAPI
    {
        /// <summary>Get the challenger league.</summary>
        public LeagueListDTO TFT_GetChallengerEntries(LoLRegion region)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, "/tft/league/v1/challenger");
        }

        /// <summary>Get league entries for a given summoner ID.</summary>
        public LeagueEntryDTO[] TFT_GetSummonerLeagues(LoLRegion region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<LeagueEntryDTO[]>(region, $"/tft/league/v1/entries/by-summoner/{encryptedSummonerId}");
        }

        /// <summary>Get all the league entries.</summary>
        /// <param name="page">Starts with page 1.</param>
        public LeagueEntryDTO TFT_GetLeagueEntries(LoLRegion region, Tier tier, Division division, int? page)
        {
            string req = $"/tft/league/v1/entries/{tier}/{division}";
            req += page != null ? $"&page={page}" : null;
            return this.MakeGETRequest<LeagueEntryDTO>(region, req);
        }

        /// <summary>Get the grandmaster league.</summary>
        public LeagueListDTO TFT_GetGrandmasterEntries(LoLRegion region)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, "/tft/league/v1/grandmaster");
        }

        /// <summary>Get league with given ID, including inactive entries.</summary>
        /// <param name="leagueId">The UUID of the league.</param>
        public LeagueListDTO TFT_GetLeagueById(LoLRegion region, int leagueId)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, $"/tft/league/v1/leagues/{leagueId}");
        }

        /// <summary>Get the master league.</summary>
        public LeagueListDTO TFT_GetMasterEntries(LoLRegion region)
        {
            return this.MakeGETRequest<LeagueListDTO>(region, "/tft/league/v1/master");
        }
    }
}
