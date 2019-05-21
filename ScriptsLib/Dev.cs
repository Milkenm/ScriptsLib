#region Usings
using System;
using System.Diagnostics;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Dev
{
	internal class Debug
	{
		bool _Debug;



		internal void Msg(string _Message, string _Title = null)
		{
			if (_Debug == true)
			{
				if (!String.IsNullOrEmpty(_Title))
				{
					MessageBox.Show(null, _Message, "DE3UG - " + _Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(null, _Message, "DE3UG", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
