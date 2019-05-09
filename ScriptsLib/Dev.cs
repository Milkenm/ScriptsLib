#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Dev
{
	internal class Debug
	{
		internal void Msg(string _Message, string _Title = null)
		{
			#if (DEBUG == true)
				if (!String.IsNullOrEmpty(_Title))
					{
						MessageBox.Show(null, _Message, "DE3UG - " + _Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(null, _Message, "DE3UG", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
			#endif
		}
	}
}
