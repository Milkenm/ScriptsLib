#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Dev
{
	/// <summary>Debug tools.</summary>
	public class Debug
	{
		/// <summary>Enables or disabled debug mode.</summary>
		public static bool _Debug { get; set; }
		/// <summary>Hide info messages if debug mode is on?</summary>
		public static bool _ErrorsOnly { get; set; }



		#region DE3UG
		/// <summary>Shows a message box.</summary>
		/// <param name="_Message">The message to be displayed.</param>
		/// <param name="_Type">Type of message.</param>
		/// <param name="_Title">Title of the message.</param>
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

		/// <summary>Type of message.</summary>
		internal enum MsgType
		{
			/// <summary>Info.</summary>
			Info,
			/// <summary>Error.</summary>
			Error,
		}
		#endregion DE3UG
	}
}
