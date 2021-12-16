using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Net;

using static ScriptsLib.APIs.GitHub.Schemes;

namespace ScriptsLib.APIs.GitHub.Tests
{
	[TestClass()]
	public class GitHubAPITests
	{
		[TestMethod()]
		public void GetLatestReleaseTest()
		{
			Release release = new GitHubAPI().GetLatestRelease("Milkenm", "AntiAFK");
			Console.WriteLine(release.TagName);
			Assert.IsTrue(true);
		}
	}
}