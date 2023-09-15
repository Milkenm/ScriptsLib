using System;
using System.Text;

using Newtonsoft.Json;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		// https://stackoverflow.com/a/56413372/10601212
		public static T DecodeBase64<T>(this string base64)
		{
			byte[] bytes = Convert.FromBase64String(base64);

			string json = Encoding.Default.GetString(bytes);

			return JsonConvert.DeserializeObject<T>(json);
		}
	}
}