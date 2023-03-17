using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

using Newtonsoft.Json;

using ScriptsLibV2.Extensions;
using ScriptsLibV2.Properties;
using ScriptsLibV2.Util;

namespace ScriptsLibV2
{
	public partial class DiscordBot
	{
		public DiscordBot(Assembly assembly, LogSeverity logLevel = LogSeverity.Info, IServiceProvider serviceProvider = null, string configPath = null)
		{
			if (configPath.IsEmpty())
			{
				configPath = $@"{Utils.GetInstallationFolder()}\bot_config.json";

				// Check if config file exists
				if (!File.Exists(configPath))
				{
					File.WriteAllBytes(configPath, Resources.DiscordBotConfig_JSON);
				}
			}
			
			LogLevel = logLevel;
			Assembly = assembly;
			ServiceProvider = serviceProvider;
			ConfigPath = configPath;

			Initialize();
		}

		public string ConfigPath { get; set; }
		public bool AllowCommandsByPrefix { get; set; } = true;
		public bool AllowCommandsByMention { get; set; } = true;
		public bool DisableCommands { get; set; }

		public LogSeverity LogLevel { get; }
		public Assembly Assembly { get; }
		public IServiceProvider ServiceProvider { get; }

		public BotConfig Configuration { get; private set; }
		public DiscordSocketClient Client { get; private set; }
		public CommandService Commands { get; private set; }
		public ActivityType ActivityType { get; private set; }
		public string ActivityText { get; private set; }
		public string StreamUrl { get; private set; }
		public UserStatus UserStatus { get; private set; }
		public bool Debugging { get; private set; }
		public bool IsRunning { get; private set; }

		private void Initialize()
		{
			CheckDebugMode();
			LoadConfig(ReadConfigAsync());

			Client = new DiscordSocketClient(new DiscordSocketConfig
			{
				LogLevel = LogLevel,
			});

			Client.MessageReceived += CommandHandlerAsync;

			Commands = new CommandService(new CommandServiceConfig
			{
				CaseSensitiveCommands = false,
				DefaultRunMode = RunMode.Async,
				LogLevel = LogLevel,
			});

			Commands.AddTypeReader(typeof(Emote), new EmoteTypeReader());
			LoadModules(Assembly, ServiceProvider).GetAwaiter().GetResult();
		}

		private BotConfig ReadConfigAsync()
		{
			string configJson = File.ReadAllText(ConfigPath);
			BotConfig cfg = JsonConvert.DeserializeObject<BotConfig>(configJson);

			return cfg;
		}

		private bool LoadConfig(BotConfig config)
		{
			bool tokenChanged = Configuration?.Token != config.Token;

			Configuration = config;

			return tokenChanged;
		}

		public async Task ReloadConfigAsync()
		{
			bool tokenChanged = LoadConfig(ReadConfigAsync());
			if (tokenChanged)
			{
				await RestartAsync();
			}
		}

		public async Task SaveConfigAsync(BotConfig config)
		{
			await Task.Run(() =>
			{
				string jsonString = JsonConvert.SerializeObject(config);
				File.WriteAllText(ConfigPath, jsonString);
			});
		}

		public async Task UpdateConfig(BotConfig config)
		{
			if (string.IsNullOrEmpty(config.Token))
			{
				config.Token = Configuration.Token;
			}
			if (string.IsNullOrEmpty(config.Prefix))
			{
				config.Prefix = Configuration.Prefix;
			}
			if (config.DebugChannels == null)
			{
				config.DebugChannels = Configuration.DebugChannels;
			}

			await SaveConfigAsync(config);
			await ReloadConfigAsync();
		}

		public void SetupEvents(
			Func<Optional<CommandInfo>, ICommandContext, IResult, Task> commandExecuted,
			Func<SocketMessage, Task> messageReceived,
			Func<Cacheable<IUserMessage, ulong>, Cacheable<IMessageChannel, ulong>, SocketReaction, Task> reactionAdded,
			Func<Cacheable<IUserMessage, ulong>, Cacheable<IMessageChannel, ulong>, SocketReaction, Task> reactionRemoved
			)
		{
			Commands.CommandExecuted += commandExecuted;
			Client.MessageReceived += messageReceived;
			Client.ReactionAdded += reactionAdded;
			Client.ReactionRemoved += reactionRemoved;
		}

		public async Task LoadModules(Assembly assembly, IServiceProvider services = null)
		{
			await Commands.AddModulesAsync(assembly, services);
		}

		public async Task SetGameAsync(ActivityType type, string text, string streamUrl = null)
		{
			ActivityType = type;
			ActivityText = text;
			if (!string.IsNullOrEmpty(streamUrl))
			{
				StreamUrl = streamUrl;
			}

			if (Client?.LoginState == LoginState.LoggedIn && !string.IsNullOrEmpty(ActivityText) && (ActivityType == ActivityType.Streaming && !string.IsNullOrEmpty(StreamUrl)))
			{
				await Client.SetGameAsync(ActivityText, StreamUrl, ActivityType);
			}
		}

		public async Task SetStatusAsync(UserStatus status)
		{
			UserStatus = status;

			if (Client?.LoginState == LoginState.LoggedIn)
			{
				await Client.SetStatusAsync(UserStatus);
			}
		}

		public async Task StartAsync()
		{
			if (IsRunning == false)
			{
				await SetGameAsync(ActivityType, ActivityText, StreamUrl);
				await SetStatusAsync(UserStatus);

				await Client.LoginAsync(TokenType.Bot, Configuration.Token);
				await Client.StartAsync();

				IsRunning = true;
			}
		}

		public async Task StopAsync()
		{
			if (IsRunning)
			{
				await Client.LogoutAsync();
				await Client.StopAsync();

				IsRunning = false;
			}
		}

		public async Task RestartAsync()
		{
			if (IsRunning)
			{
				await StopAsync();
				await StartAsync();
			}
		}

		private async Task CommandHandlerAsync(SocketMessage socketMsg)
		{
			if (!(socketMsg is SocketUserMessage msg) || (!Debugging && Configuration.DebugChannels.Contains(msg.Channel.Id)) || (Debugging && !Configuration.DebugChannels.Contains(msg.Channel.Id)))
			{
				return;
			}

			int argPos = 0;
			if (DisableCommands || !AllowCommandsByPrefix || msg.Author.IsBot || !(msg.HasStringPrefix(Configuration.Prefix, ref argPos) || (msg.HasMentionPrefix(Client.CurrentUser, ref argPos) && AllowCommandsByMention)))
			{
				return;
			}

			SocketCommandContext context = new SocketCommandContext(Client, msg);

			await Commands.ExecuteAsync(context, argPos, null);
		}

		public void AddDebugChannels(params ulong[] channelsIds)
		{
			foreach (ulong channelId in channelsIds)
			{
				Configuration.DebugChannels.Add(channelId);
			}
		}

		[Conditional("DEBUG")]
		public void CheckDebugMode()
		{
			Debugging = true;
		}
	}
}
