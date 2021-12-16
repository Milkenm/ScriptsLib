using System.Net;

using static ScriptsLib.APIs.GitHub.Schemes;
using static ScriptsLib.Network.Requests;
using static ScriptsLib.Unsorted.Unsorted;

namespace ScriptsLib.APIs.GitHub
{
	public partial class GitHubAPI
	{
		public Release GetLatestRelease(string user, string repo)
		{
			HttpWebRequest request = GetHttpWebRequest($"{APIOrigin}repos/{user}/{repo}/releases/latest");
			request.UserAgent = "request";
			return GET<Release>(request);
		}
	}
}