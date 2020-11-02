using System.IO;
using System.Net;

namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		/// <param name="headers">The request headers.</param>
		/// https://stackoverflow.com/a/8091963/10601212
		/// https://stackoverflow.com/a/10027534/10601212
		public static string POST(string url, string json, WebHeaderCollection headers)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.ContentType = "application/json";
			request.Method = "POST";

			if (headers != null)
			{
				request.Headers = headers;
			}

			using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
			{
				sw.Write(json);
			}

			return ParseResponse(request.GetResponse());
		}

		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		/// https://stackoverflow.com/a/8091963/10601212
		/// https://stackoverflow.com/a/10027534/10601212
		public static string POST(string url, string json)
		{
			return POST(url, json, null);
		}
	}
}