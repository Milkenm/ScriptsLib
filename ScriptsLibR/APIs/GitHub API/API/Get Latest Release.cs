using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptsLibR.APIs
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
