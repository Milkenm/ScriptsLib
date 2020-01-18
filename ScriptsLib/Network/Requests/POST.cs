#region Usings
using System.IO;
using System.Net;
#endregion Usings

// # = #
// POST Request: https://stackoverflow.com/a/8091963/10601212
// POST Request (2): https://stackoverflow.com/a/10027534/10601212
// # = #

namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		/// <summary>Executes a POST Resquest.</summary>
		/// <param name="url">The API URL.</param>
		/// <param name="dataJson">The JSON string containing the values to be sent to the API.</param>
		public static string POST(string url, string dataJson)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(dataJson);
			}

			HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
			{
				return streamReader.ReadToEnd();
			}
		}
	}
}