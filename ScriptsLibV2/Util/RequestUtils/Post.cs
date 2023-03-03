using ScriptsLibV2.Extensions;

using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ScriptsLibV2.Util
{
	public static partial class RequestUtils
	{
		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		/// <param name="headers">The request headers.</param>
		/// https://stackoverflow.com/a/8091963/10601212
		/// https://stackoverflow.com/a/10027534/10601212
		public static string Post(string url, string json, WebHeaderCollection headers)
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

			return request.GetResponse().ParseAsString();
		}

		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		/// https://stackoverflow.com/a/8091963/10601212
		/// https://stackoverflow.com/a/10027534/10601212
		public static string Post(string url, string json)
		{
			return Post(url, json, null);
		}

		/// <summary>Executes an async POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		/// <param name="headers">The request headers.</param>
		public static async Task<string> PostAsync(string url, string json, WebHeaderCollection headers)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.ContentType = "application/json";
			request.Method = "POST";

			if (headers != null)
			{
				request.Headers = headers;
			}

			using (StreamWriter sw = new StreamWriter(await request.GetRequestStreamAsync()))
			{
				sw.Write(json);
			}

			WebResponse response = await request.GetResponseAsync();
			return await response.ParseAsStringAsync();
		}

		/// <summary>Executes an async POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="json">The JSON string to be sent to the API.</param>
		public static async Task<string> PostAsync(string url, string json)
		{
			return await PostAsync(url, json, null);
		}
	}
}
