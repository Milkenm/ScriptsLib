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
			#region JSON
			public class ShardStatus
			{
				public string name;
				public string region_tag;
				public string hostname;
				public List<Service> services;
				public string slug;
				public List<string> locales;
			}

			public class Service
			{
				public string status;
				public List<Incident> incidents;
				public string name;
				public string slug;
			}

			public class Incident
			{
				public bool active;
				public string created_at;
				public long id;
				public List<Message> updates;
			}

			public class Message
			{
				public string severity;
				public string author;
				public string created_at;
				public List<Translation> translations;
				public string updated_at;
				public string content;
				public string id;
			}

			public class Translation
			{
				public string locale;
				public string content;
				public string updated_at;
			}
			#endregion JSON





			/// <summary>Get League of Legends status for the given shard.</summary>
			public static string GetLolStatus()
			{
				return GET(ServerString() + "/lol/status/v3/shard-data" + ApiString());
			}
		}
	}
}
