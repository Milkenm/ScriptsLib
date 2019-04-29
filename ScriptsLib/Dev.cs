#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Dev
{
	public class Debug
	{
		public readonly bool _Debug = false;



		public void Msg(string _Message, string _Title = null)
		{
			if (_Debug == true)
			{
				MessageBox.Show(null, _Message, $"DE3UG - {_Title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
