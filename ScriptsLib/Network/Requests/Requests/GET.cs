using Newtonsoft.Json;

using System;
using System.Net;

namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>
		/// Executes a GET request.
		/// </summary>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest.</returns>
		public static string GET(HttpWebRequest request)
		{
			/* HttpStatusCode a = ((HttpWebResponse)request.GetResponse()).StatusCode; */
			return ParseResponse(request.GetResponse());
		}

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

			return GET(request);
		}

		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		public static string GET(string url)
		{
			return GET(url, null);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest as T.</returns>
		public static T GET<T>(HttpWebRequest request)
		{
			string response = GET(request);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
		/// <returns>The response as T.</returns>
		public static T GET<T>(string url, WebHeaderCollection headers)
		{
			string response = GET(url, headers);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <returns>The response as T.</returns>
		public static T GET<T>(string url)
		{
			return GET<T>(url);
		}
	}
}