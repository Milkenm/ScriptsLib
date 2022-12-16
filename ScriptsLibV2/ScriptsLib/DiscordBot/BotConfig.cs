using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ScriptsLibV2
{
	public partial class DiscordBot
	{
		public class BotConfig
		{
			[JsonProperty("token")] public string Token { get; set; }
			[JsonProperty("prefix")] public string Prefix { get; set; }
			[JsonProperty("debugChannels")] public List<ulong> DebugChannels { get; set; } = new List<ulong>();
		}
	}
}
