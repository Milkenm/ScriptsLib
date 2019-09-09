#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace TestingGrounds
{
	internal static class Program
	{
		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		internal static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
