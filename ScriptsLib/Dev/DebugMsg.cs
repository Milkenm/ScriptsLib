#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Dev
	{
		/// <summary>Shows a message box.</summary>
		/// <param name="_Message">The message to be displayed.</param>
		/// <param name="_Type">Type of message.</param>
		/// <param name="_Title">Title of the message.</param>
		internal static void Msg(string _Message, MsgType _Type, string _Title = null)
		{
			try
			{
				if (_Debug == true)
				{
					if (_ErrorsOnly == true && _Type == MsgType.Error)
					{
						if (!string.IsNullOrEmpty(_Title))
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
						if (!string.IsNullOrEmpty(_Title))
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
			Info,
			Error,
		}
	}
}
