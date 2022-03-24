using NUnit.Framework;

using ScriptsLibR.APIs.GitHubAPI;

namespace SlTestingR.APIs.GitHubAPITests
{
	internal class GetLatestRelease
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
			Assert.IsTrue(latestRelease.TagName.ToLower().StartsWith("v."));
		}
	}
}
