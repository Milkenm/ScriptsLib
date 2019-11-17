namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static readonly string RiotAPIOrigin = "https://{0}.api.riotgames.com";

		private static string ApiString() => "?api_key=" + ApiKey;
		private static string ServerString() => string.Format(RiotAPIOrigin, Region);



		#region Enums
		public enum Regions
		{
			RU,
			KR,
			BR1,
			OC1,
			JP1,
			NA1,
			EUN1,
			EUW1,
			TR1,
			LA1,
			LA2,
		}

		public enum Queues
		{
			RANKED_SOLO_5x5,
			RANKED_TFT,
			RANKED_FLEX_SR,
			RANKED_FLEX_TT,
		}

		public enum Tiers
		{
			IRON,
			BRONZE,
			SILVER,
			GOLD,
			PLATINUM,
			DIAMOND,
			MASTER,
			GRANDMASTER,
			CHALLENGER,
		}

		public enum Divisions
		{
			I,
			II,
			III,
			IV,
		}
		#endregion Enums

		public static string ApiKey;
		public static Regions Region;
	}
}