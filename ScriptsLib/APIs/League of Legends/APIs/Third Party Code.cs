using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class ThirdPartyCode // v4
		{
			/// <summary>Get third party code for a given summoner ID.</summary>
			public string GetThirdPartyCodeBySummonerId(Regions region, string encryptedSummonerId)
			{
				return GET(ServerString(region) + $"/lol/platform/v4/third-party-code/by-summoner/{encryptedSummonerId}" + ApiString());
			}
		}
	}
}
