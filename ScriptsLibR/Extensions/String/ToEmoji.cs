using Discord;

namespace ScriptsLibR.Extensions
{
	public static partial class StringExtensions
	{
		public static IEmote ToEmote(this string emote)
		{
			IEmote parsedEmote;

			try
			{
				parsedEmote = Emote.Parse(emote);
			}
			catch
			{
				parsedEmote = new Emoji(emote);
			}

			return parsedEmote;
		}
	}
}
