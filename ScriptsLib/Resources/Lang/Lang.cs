namespace ScriptsLib.Resources.Lang
{
	public class Lang
	{
		#region Variables
		internal static string _Language = "English (en_EN)";
		internal static string _ScriptsLibTitle = "ScriptsLib";
		internal static string _ErrorTitle = $"{_ScriptsLibTitle} - Error";
		internal static string _ErrorSocketException = "There was an error creating a connection to the remote server.Check if the remote IP adress and port number are correct or that the remote server is not offline.\n\n\n\n\nDetails:\n\n{0}";
		#endregion Variables






		#region Load Lang
		public void LoadLang(string _Lang)
		{
			if (_Lang == "en_EN")
			{
				_Language = new en_EN()._Language;
				_ScriptsLibTitle = new en_EN()._ScriptsLibTitle;
				_ErrorTitle = new en_EN()._ErrorTitle;
				_ErrorSocketException = new en_EN()._ErrorSocketException;
			}
		}
		#endregion Load Lang
	}
}
