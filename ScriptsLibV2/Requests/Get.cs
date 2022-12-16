using Newtonsoft.Json;

using ScriptsLibV2.Extensions;

using System;
using System.Net;
using System.Threading.Tasks;

namespace ScriptsLibV2.Requests
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

			return response.ParseAsString();
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
			string response = Get(url);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes an asynchronous GET request.
		/// </summary>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest.</returns>
		public static async Task<string> GetAsync(HttpWebRequest request)
		{
			WebResponse response = await request.GetResponseAsync();
			response.GetStatusCode(false);

			return await response.ParseAsStringAsync();
		}

		/// <summary>Executes an asynchronous GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
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

		/// <summary>Executes an asynchronous GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		public static async Task<string> GetAsync(string url)
		{
			return await GetAsync(url, null);
		}

		/// <summary>
		/// Executes an asynchronous GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="request">The HttpWebRequest object to get the response from.</param>
		/// <returns>The response from the HttpWebRequest as T.</returns>
		public static async Task<T> GetAsync<T>(HttpWebRequest request)
		{
			string response = await GetAsync(request);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes an asynchronous GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <param name="headers">The request headers.</param>
		/// <returns>The response as T.</returns>
		public static async Task<T> GetAsync<T>(string url, WebHeaderCollection headers)
		{
			string response = await GetAsync(url, headers);
			return JsonConvert.DeserializeObject<T>(response);
		}

		/// <summary>
		/// Executes an asynchronous GET request and deserializes it to T.
		/// </summary>
		/// <typeparam name="T">The schema class to return the response in.</typeparam>
		/// <param name="url">The request URL (or API URL).</param>
		/// <returns>The response as T.</returns>
		public static async Task<T> GetAsync<T>(string url)
		{
			string response = await GetAsync(url);
			return JsonConvert.DeserializeObject<T>(response);
		}
	}
}
