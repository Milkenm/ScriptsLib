using System.Threading.Tasks;

using Discord;
using Discord.WebSocket;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public partial class DiscordBot
	{
		public DiscordBot(string token, LogSeverity logLevel)
		{
			Token = token;
			LogLevel = logLevel;
		}

		public DiscordBot() { }

		public string Token { get; set; }
		public LogSeverity LogLevel { get; set; }

		public void Initialize()
		{
			Client = new DiscordSocketClient(new DiscordSocketConfig
			{
				LogLevel = this.LogLevel,
			});
		}

		public DiscordSocketClient Client { get; private set; }
		public bool IsRunning { get; private set; }

		public async Task SetGameAsync(ActivityType activityType, string activityName, string? streamUrl = null)
		{
			if (Client?.LoginState == LoginState.LoggedIn && (!activityName.IsEmpty() || (activityType == ActivityType.Streaming && !streamUrl.IsEmpty())))
			{
				await Client.SetGameAsync(activityName, streamUrl, activityType);
			}
		}

		public async Task SetStatusAsync(UserStatus status)
		{
			if (Client?.LoginState == LoginState.LoggedIn)
			{
				await Client.SetStatusAsync(status);
			}
		}

		public async Task StartAsync()
		{
			if (IsRunning == false)
			{
				await Client.LoginAsync(TokenType.Bot, Token);
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
	}
}
