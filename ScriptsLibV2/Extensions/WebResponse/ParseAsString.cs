using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScriptsLibV2.Extensions
{
	public static partial class WebResponseExtensions
	{
		public static string ParseAsString(this WebResponse response)
		{
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}

		public static async Task<string> ParseAsStringAsync(this WebResponse response)
		{
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return await reader.ReadToEndAsync();
			}
		}
	}
}
