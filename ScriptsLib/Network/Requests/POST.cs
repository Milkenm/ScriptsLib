#region Usings
using System.Collections.Specialized;
using System.Net;
using System.Text;
#endregion Usings

// # = #
// POST Request: https://stackoverflow.com/a/8091963/10601212
// # = #


namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="values">Values to be sent to the API.</param>
		public static string POST(string url, NameValueCollection data)
		{
			using (WebClient wb = new WebClient())
			{
				byte[] res = wb.UploadValues(url, "POST", data);
				return Encoding.UTF8.GetString(res);
			}
		}
	}
}