using System.Net;

namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
		public static string GET(string url, WebHeaderCollection headers)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			if (headers != null)
			{
				request.Headers = headers;
			}

			return ParseResponse(request.GetResponse());
		}

		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		public static string GET(string url)
		{
			return GET(url, null);
		}
	}
}