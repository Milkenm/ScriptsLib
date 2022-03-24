using Newtonsoft.Json;

using ScriptsLibR.Extensions;

using System;
using System.Net;
using System.Threading.Tasks;

namespace ScriptsLibR.Requests
{
	public static partial class Request
	{
		/// <summary>
		/// Executes a GET request.
		/// </summary>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest.</returns>
		public static string Get(HttpWebRequest request)
		{
			if (request == null)
			{
				throw new ArgumentNullException(nameof(request));
			}

			WebResponse response = request.GetResponse();
			response.GetStatusCode(false);

			return request.GetResponse().ParseAsString();
		}

		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
		public static string Get(string url, WebHeaderCollection headers)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			if (headers != null)
			{
				request.Headers = headers;
			}

			return Get(request);
		}

		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		public static string Get(string url)
		{
			return Get(url, null);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest as T.</returns>
		public static T Get<T>(HttpWebRequest request)
		{
			string response = Get(request);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
		/// <returns>The response as T.</returns>
		public static T Get<T>(string url, WebHeaderCollection headers)
		{
			string response = Get(url, headers);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes a GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <returns>The response as T.</returns>
		public static T Get<T>(string url)
		{
			return Get<T>(url);
		}

		// TODO
		public static async Task<string> GetAsync(HttpWebRequest request)
		{
			WebResponse response = await request.GetResponseAsync();
			response.GetStatusCode(false);

			return await response.ParseAsStringAsync();
		}

		public static async Task<string> GetAsync(string url, WebHeaderCollection headers)
		{
			if (url == null)
			{
				throw new ArgumentNullException(nameof(url));
			}
			if (headers == null)
			{
				throw new ArgumentNullException(nameof(headers));
			}

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Headers = headers;

			return await GetAsync(request);
		}
	}
}
