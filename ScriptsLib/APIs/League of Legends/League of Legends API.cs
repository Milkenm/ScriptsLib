namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public LeagueOfLegendsAPI(string apiKey)
		{
			ApiKey = apiKey;
		}

		public static readonly string RiotAPIOrigin = "https://{0}.api.riotgames.com";

		public static string ApiKey { get; private set; }

		private static string ApiString()
		{
			return "?api_key=" + ApiKey;
		}

		private static string ServerString(Regions region)
		{
			return string.Format(RiotAPIOrigin, region);
		}
	}
}