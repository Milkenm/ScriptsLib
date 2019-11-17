#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class ThirdPartyCode // v4
		{
			/// <summary>Get third party code for a given summoner ID.</summary>
			public static string GetThirdPartyCodeBySummonerId(string encryptedSummonerId) => GET(ServerString() + $"/lol/platform/v4/third-party-code/by-summoner/{encryptedSummonerId}" + ApiString());
		}
	}
}
