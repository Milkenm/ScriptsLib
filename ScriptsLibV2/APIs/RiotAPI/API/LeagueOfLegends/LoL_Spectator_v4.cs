namespace ScriptsLibV2.APIs
{
    /// LoL Spectator - v4
    public partial class RiotAPI
    {
        /// <summary>Get current game information for the given summoner ID</summary>
        /// <param name="encryptedSummonerId">The ID of the summoner.</param>
        public CurrentGameInfo LoL_GetCurrentGameInfo(Region region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<CurrentGameInfo>(region, $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}");
        }

        /// <summary>Get list of featured games.</summary>
        public FeaturedGames LoL_GetFeaturedGames(Region region)
        {
            return this.MakeGETRequest<FeaturedGames>(region, "/lol/spectator/v4/featured-games");
        }
    }
}