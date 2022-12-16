namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL League Exp - v4
    public partial class RiotGamesAPI
    {
        /// <summary>Get all the league entries.</summary>
        /// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
        public LeagueEntryDTO[] LoL_GetLeagueEntries(LoLRegion region, string queue, string tier, string division)
        {
            return this.MakeGETRequest<LeagueEntryDTO[]>(region, $"/lol/league-exp/v4/entries/{queue}/{tier}/{division}");
        }
    }
}
