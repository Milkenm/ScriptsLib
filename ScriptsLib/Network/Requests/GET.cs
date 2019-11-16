#region Usings
using System.IO;
using System.Net;
using System.Text;
#endregion Usings



namespace ScriptsLib.Network.Requests
{
	public static partial class Requests
	{
		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL (or API URL).</param>
		public static string GET(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			WebResponse response = request.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}
	}
}
