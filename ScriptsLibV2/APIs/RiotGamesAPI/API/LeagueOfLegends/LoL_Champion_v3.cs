namespace ScriptsLibV2.APIs.RiotGames
{
	/// LoL Champion - v3
	public partial class RiotGamesAPI
	{
		/// <summary>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</summary>
		public ChampionInfo LoL_GetChampionRotation(LoLRegion region)
		{
			return MakeGETRequest<ChampionInfo>(region, "/lol/platform/v3/champion-rotations");
		}
	}
}
