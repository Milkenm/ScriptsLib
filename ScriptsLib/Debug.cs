#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Debug
{
	public class Errors
	{
		public readonly bool _Debug = false;



		public void Msg(string _Message, string _Title)
		{
			if (_Debug == true)
			{
				MessageBox.Show(null, _Message, $"DE3UG - {_Title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
