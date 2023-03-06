using NUnit.Framework;

using ScriptsLibV2.APIs.GitHubAPI;

namespace APIs
{
	internal class GitHub_GetLatestRelease
	{
		private GitHubAPI api;

		[SetUp]
		public void Setup()
		{
			api = new GitHubAPI();
		}

		[Test]
		public void TEST_GetLatestRelease()
		{
			Release latestRelease = api.GetLatestRelease("Milkenm", "ScriptsLib");
			Assert.IsTrue(latestRelease.TagName.ToLower().StartsWith("v"));
		}
	}
}
