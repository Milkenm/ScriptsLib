namespace ScriptsLibR.APIs.RiotAPI
{
    /// LoL Champion - v3
    public partial class RiotAPI
    {
        /// <summary>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</summary>
        public dynamic LoL_GetChampionRotation(Region region)
        {
            return this.MakeGETRequest<ChampionInfo>(region, "/lol/platform/v3/champion-rotations");
        }
    }
}
