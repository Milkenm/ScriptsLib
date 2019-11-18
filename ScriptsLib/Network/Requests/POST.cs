#region Usings
using System.Net.Http;
#endregion Usings

// # = #
// POST Requests: https://stackoverflow.com/a/4015346
// # = #


namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="values">Values to be sent to the API.</param>
		public static string POST(string url, dynamic values)
		{
			return new HttpClient().PostAsync("http://www.example.com/recepticle.aspx", new FormUrlEncodedContent(values)).GetAwaiter().GetResult().Content.ReadAsStringAsync().GetAwaiter().GetResult();
		}
	}
}