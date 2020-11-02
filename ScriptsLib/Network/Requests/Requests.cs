using System.IO;
using System.Net;
using System.Text;

namespace ScriptsLib.Network
{
	public static partial class Requests
	{
		public static string ParseResponse(WebResponse response)
		{
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}
	}
}