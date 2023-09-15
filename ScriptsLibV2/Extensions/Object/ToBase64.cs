using System;
using System.Text;

using Newtonsoft.Json;

namespace ScriptsLibV2.Extensions
{
	public static partial class ObjectExtensions
	{
		// https://stackoverflow.com/a/56413372/10601212
		public static string ToBase64(this object obj)
		{
			string json = JsonConvert.SerializeObject(obj);

			byte[] bytes = Encoding.Default.GetBytes(json);

			return Convert.ToBase64String(bytes);
		}
	}
}
