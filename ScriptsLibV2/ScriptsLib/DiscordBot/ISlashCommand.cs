using System.Threading.Tasks;

using Discord;
using Discord.WebSocket;

namespace ScriptsLibV2.ScriptsLib.DiscordBot
{
	public abstract class ISlashCommand : SlashCommandBuilder
	{
		public SlashCommandProperties GetSlashCommand()
		{
			SlashCommandBuilder();
			return Build();
		}

		public Task GetAction(SocketSlashCommand command, DiscordSocketClient client)
		{
			return Action(command, client);
		}

		protected abstract void SlashCommandBuilder();

		protected abstract Task Action(SocketSlashCommand command, DiscordSocketClient client);
	}
}
