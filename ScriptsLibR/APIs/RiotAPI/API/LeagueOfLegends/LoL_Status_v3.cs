namespace ScriptsLibR.APIs.RiotAPI
{
    /// LoL Lol Status - v3
    public partial class RiotAPI
    {
        /// <summary>Get League of Legends status for the given shard.</summary>
        public ShardStatus LoL_GetLolStatus(Region region)
        {
            return this.MakeGETRequest<ShardStatus>(region, "/lol/status/v3/shard-data");
        }
    }
}
