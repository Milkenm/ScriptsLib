#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Dev
{
	public class Debug
	{
		public static bool _Debug { get; set; }
		public static bool _ErrorsOnly { get; set; }



		#region DE3UG
		internal void Msg(string _Message, MsgType _Type, string _Title = null)
		{
			try
			{
				if (_Debug == true)
				{
					if (_ErrorsOnly == true && _Type == MsgType.Error)
					{
						if (!String.IsNullOrEmpty(_Title))
						{
							MessageBox.Show(null, _Message, "ScriptsLib Error - " + _Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(null, _Message, "ScriptsLib Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else if (_ErrorsOnly == false)
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
			catch { }
		}

		internal enum MsgType
		{
			Info,
			Error,
		}
		#endregion DE3UG
	}
}
