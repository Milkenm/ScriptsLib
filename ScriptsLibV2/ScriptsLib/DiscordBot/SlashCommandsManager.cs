using System.Collections.Generic;
using System.Threading.Tasks;

using Discord.WebSocket;

using ScriptsLibV2.ScriptsLib.DiscordBot;

namespace ScriptsLibV2
{
	public partial class SlashCommandsManager
	{
		private DiscordSocketClient Client { get; set; }

		private readonly Dictionary<ulong, ISlashCommand> CommandActionsList = new Dictionary<ulong, ISlashCommand>();

		public SlashCommandsManager(DiscordSocketClient client)
		{
			Client = client;
			Client.SlashCommandExecuted += Client_SlashCommandExecuted;
		}

		public async Task RemoveAllCommands()
		{
			foreach (SocketApplicationCommand sac in await Client.GetGlobalApplicationCommandsAsync())
			{
				await sac.DeleteAsync();
			}
		}

		public async Task AddSlashCommandsAsync(params ISlashCommand[] slashCommands)
		{
			foreach (ISlashCommand command in slashCommands)
			{
				await AddSlashCommandAsync(command);
			}
		}

		public async Task AddSlashCommandAsync(ISlashCommand slashCommand)
		{
			SocketApplicationCommand cmd = await Client.CreateGlobalApplicationCommandAsync(slashCommand.GetSlashCommand());
			CommandActionsList.Add(cmd.Id, slashCommand);
		}

		private async Task Client_SlashCommandExecuted(SocketSlashCommand arg)
		{
			if (CommandActionsList.ContainsKey(arg.CommandId))
			{
				ISlashCommand slashCommand = CommandActionsList[arg.CommandId];
				await slashCommand.GetAction(arg, Client);
			}
		}
	}
}
