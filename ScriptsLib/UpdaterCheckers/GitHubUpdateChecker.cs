using ScriptsLib.APIs.GitHub;

using System;
using System.Windows.Forms;

namespace ScriptsLib.UpdaterCheckers
{
	public class GitHubUpdaterChecker
	{
		private string User;
		private string Repo;
		private string CurrentVersion;
		private int UpdateInterval;

		private readonly Timer timer = new Timer();
		private readonly GitHubAPI gitHubApi = new GitHubAPI();

		public delegate void NewUpdateEvent(string newVersion);
		public event NewUpdateEvent OnNewUpdate;

		/// <summary>
		/// Checks for new releases in a GitHub repo.
		/// </summary>
		/// <param name="user">Repository owner.</param>
		/// <param name="repo">Repository name (must be public).</param>
		/// <param name="currentVersion">Current application version (git tag), used to compare with GitHub's latest.</param>
		/// <param name="updateInterval">The delay, in seconds, to search for a new version. Use 0 to disable.</param>
		public GitHubUpdaterChecker(string user, string repo, string currentVersion, int updateInterval)
		{
			this.SetUser(user);
			this.SetRepo(repo);
			this.SetCurrentVersion(currentVersion);
			this.SetUpdateInterval(updateInterval);

			timer.Tick += this.TimerTick;
		}

		public string GetUser()
		{
			return User;
		}

		public void SetUser(string user)
		{
			User = user;
		}

		public string GetRepo()
		{
			return Repo;
		}

		public void SetRepo(string repo)
		{
			Repo = repo;
		}

		public string GetCurrentVersion()
		{
			return CurrentVersion;
		}

		public void SetCurrentVersion(string currentVersion)
		{
			CurrentVersion = currentVersion;
		}

		public int GetUpdateInterval()
		{
			return UpdateInterval;
		}

		public void SetUpdateInterval(int updateInterval)
		{
			UpdateInterval = updateInterval;
			if (UpdateInterval < 0)
			{
				UpdateInterval = 0;
			}

			if (UpdateInterval == 0)
			{
				timer.Stop();
			}
			else
			{
				timer.Interval = UpdateInterval;
				timer.Stop();
				timer.Start();
			}
		}

		private void TimerTick(object sender, EventArgs e)
		{
			this.CheckForUpdates();
		}

		public void CheckForUpdates()
		{
			string latestVersion = gitHubApi.GetLatestRelease(User, Repo).TagName;
			if (latestVersion != CurrentVersion)
			{
				OnNewUpdate?.Invoke(latestVersion);
			}
		}
	}
}
