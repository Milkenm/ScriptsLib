﻿using ScriptsLibV2.Util;

using System.Net;

namespace ScriptsLibV2.APIs.GitHubAPI
{
	public partial class GitHubAPI
	{
		public Release GetLatestRelease(string user, string repo)
		{
			HttpWebRequest request = GetHttpWebRequest($"{APIOrigin}repos/{user}/{repo}/releases/latest");
			request.UserAgent = "request";
			return RequestUtils.Get<Release>(request);
		}

		public static HttpWebRequest GetHttpWebRequest(string url)
		{
			return (HttpWebRequest)WebRequest.Create(url);
		}
	}
}