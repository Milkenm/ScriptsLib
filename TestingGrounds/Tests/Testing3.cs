#region Usings
using System;
using System.Net;
using System.Windows.Forms;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Testing
	{
		/// <summary>Packets 2.</summary>
		internal static void Testing3()
		{
			HttpListener l = new HttpListener();
			AsyncCallback callback = new AsyncCallback(Callback);
			l.Start();
			l.BeginGetContext(callback, "h");
		}

		internal static void Callback(IAsyncResult result)
		{
			MessageBox.Show(result.AsyncState.ToString());
		}
	}
}
