#region Usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Testing
	{
		/// <summary>League of Legends API.</summary>
		internal static void Testing1()
		{
			string _ApiKey = "";

			MessageBox.Show(GET("https://euw1.api.riotgames.com/lol/platform/v3/champion-rotations?api_key=" + _ApiKey));
			string json = "jj";
			JsonConvert.DeserializeObject<RootChampionDTO>(json);
		}

		internal class RootChampionDTO
		{
			internal static string Type { get; set; }
			internal static string Version { get; set; }
			internal static Dictionary<string, Champion> Data { get; set; }
		}

		internal class Champion
		{
			internal static int id { get; set; }
			internal static string key { get; set; }
			internal static string name { get; set; }
			internal static string title { get; set; }
		}

		internal static string GET(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			try
			{
				WebResponse response = request.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
					return reader.ReadToEnd();
				}
			}
			catch (WebException ex)
			{
				WebResponse errorResponse = ex.Response;
				using (Stream responseStream = errorResponse.GetResponseStream())
				{
					StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
					String errorText = reader.ReadToEnd();
				}
				throw;
			}
		}
	}
}
