#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class Champion // v3
		{
			/// <summary>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetChampionRotation(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/lol/platform/v3/champion-rotations" + ApiString());

				return ReturnResponse<ChampionInfo>(request, getJsonObject);
			}
		}
	}
}
