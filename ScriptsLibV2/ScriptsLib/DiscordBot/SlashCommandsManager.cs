using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Discord;
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

		public async Task AddSlashCommandsAsync(params ISlashCommand[] slashCommands)
		{
			List<ApplicationCommandProperties> commandPropertiesList = new List<ApplicationCommandProperties>();

			foreach (ISlashCommand command in slashCommands)
			{
				try
				{
					SlashCommandProperties commandProperties = command.GetSlashCommand();
					commandPropertiesList.Add(commandProperties);
				}
				catch
				{
					Debug.WriteLine($"Error while registering command '{command.Name}'.");
				}
			}

			IReadOnlyCollection<SocketApplicationCommand>? socketAppCommands = await Client.BulkOverwriteGlobalApplicationCommandsAsync(commandPropertiesList.ToArray());

			foreach (SocketApplicationCommand socketAppCommand in socketAppCommands)
			{
				CommandActionsList.Add(socketAppCommand.Id, slashCommands.First(cmd => cmd.Name == socketAppCommand.Name));
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
