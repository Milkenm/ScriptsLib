#region Usings
using System.Net.NetworkInformation;
using System.Windows.Forms;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Testing
	{
		/// <summary>Packets.</summary>
		internal static void Testing2()
		{
			IPGlobalProperties a = IPGlobalProperties.GetIPGlobalProperties();
			TcpConnectionInformation[] con = a.GetActiveTcpConnections();
			foreach (TcpConnectionInformation tcp in con)
			{
				MessageBox.Show(tcp.LocalEndPoint.Address.ToString());
			}
		}
	}
}
