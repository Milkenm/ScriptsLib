namespace ScriptsLibR.APIs
{
    public partial class GitHubAPI
    {
        private static GitHubAPI Instance;
        public static GitHubAPI GetInstance()
        {
            return Instance ?? new GitHubAPI();
        }

        public GitHubAPI()
        {
            Instance = this;
        }

        private readonly string APIOrigin = "https://api.github.com/";
    }
}
