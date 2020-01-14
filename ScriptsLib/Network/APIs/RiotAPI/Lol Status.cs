#region Usings
using System.Collections.Generic;

using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class LolStatus // v3
		{
			/// <summary>Get League of Legends status for the given shard.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetLolStatus(bool getJsonObject = false)
			{
				string request = GET(ServerString() + "/lol/status/v3/shard-data" + ApiString());

				return ReturnRequest<ShardStatus>(request, getJsonObject);
			}
		}
	}
}
