#region Usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using NetFwTypeLib;
using Newtonsoft.Json;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			_MainForm = this;
			MainInitEvents();
		}



		#region Test Button
		// # ================================================================================================ #
		private void button_tg_test_Click(object sender, EventArgs e)
		{
			try
			{
				switch (numeric_tg_testingIndex.Value)
				{
					case 1:
						Testing1(); break;
					case 2:
						Testing2(); break;
					case 3:
						Testing3(); break;
					case 4:
						Testing4(); break;
					case 5:
						Testing5(); break;
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		#region Testing 1 - League of Legends API
		// # ================================================================================================ #
		void Testing1()
		{
			string _ApiKey = "";

			MessageBox.Show(GET("https://euw1.api.riotgames.com/lol/platform/v3/champion-rotations?api_key=" + _ApiKey));
			string json = "jj";
			JsonConvert.DeserializeObject<RootChampionDTO>(json);
		}

		public class RootChampionDTO
		{
			public string Type { get; set; }
			public string Version { get; set; }
			public Dictionary<string, Champion> Data { get; set; }
		}

		public class Champion
		{
			public int id { get; set; }
			public string key { get; set; }
			public string name { get; set; }
			public string title { get; set; }
		}

		public string GET(string url)
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
		// # ================================================================================================ #
		#endregion Testing 1 - League of Legends API

		#region Testing 2 - Packets
		// # ================================================================================================ #
		void Testing2()
		{
			IPGlobalProperties a = IPGlobalProperties.GetIPGlobalProperties();
			TcpConnectionInformation[] con = a.GetActiveTcpConnections();
			foreach (TcpConnectionInformation tcp in con)
			{
				MessageBox.Show(tcp.LocalEndPoint.Address.ToString());
			}
		}
		// # ================================================================================================ #
		#endregion Testing 2 - Packets

		#region Testing 3 - Packets 2
		// # ================================================================================================ #
		void Testing3()
		{
			HttpListener l = new HttpListener();
			AsyncCallback callback = new AsyncCallback(Callback);
			l.Start();
			l.BeginGetContext(callback, "h");
		}

		static void Callback(IAsyncResult result)
		{
			MessageBox.Show(result.AsyncState.ToString());
		}
		// # ================================================================================================ #
		#endregion Testing 3 - Packets 2

		#region Testing 4 - Create Firewall Rule
		// # ================================================================================================ #
		void Testing4()
		{
			// Moved to ScriptsLib.
		}
		// # ================================================================================================ #
		#endregion Testing 4 - Create Firewall Rule

		#region Testing 5 - Get Type (for DynVars)
		// # ================================================================================================ #
		void Testing5()
		{
			Type _Type1 = Type.GetType("int");
			Type _Type2 = Type.GetType("System.Int32");
			Type _Type3 = Type.GetType("System.String");

			MessageBox.Show($"Types:\n	1 > {_Type1}\n	2 > {_Type2}\n	3 > {_Type3}");
		}
        // # ================================================================================================ #
        #endregion Testing 5 - Get Type (for DynVars)
        // # ================================================================================================ #
        #endregion Test Button
    }
}