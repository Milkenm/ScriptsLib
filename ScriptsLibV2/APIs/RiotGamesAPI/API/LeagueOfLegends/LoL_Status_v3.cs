namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL Lol Status - v3
    public partial class RiotGamesAPI
    {
        /// <summary>Get League of Legends status for the given shard.</summary>
        public ShardStatus LoL_GetLolStatus(LoLRegion region)
        {
            return this.MakeGETRequest<ShardStatus>(region, "/lol/status/v3/shard-data");
        }
    }
}
