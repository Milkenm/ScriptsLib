#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Internal
{
	internal class Debug
	{
		private readonly bool _Debug = false;



		internal void Msg(string _Message, string _Title)
		{
			if (_Debug == true)
			{
				MessageBox.Show(null, _Message, $"DE3UG - {_Title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
