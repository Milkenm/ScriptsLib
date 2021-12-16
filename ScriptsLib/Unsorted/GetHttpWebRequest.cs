using System.Net;

namespace ScriptsLib.Unsorted
{
	public static partial class Unsorted
	{
		public static HttpWebRequest GetHttpWebRequest(string url)
		{
			return (HttpWebRequest)WebRequest.Create(url);
		}
	}
}
