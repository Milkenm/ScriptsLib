#region Usings
using ScriptsLib.Internal.Lang;
#endregion Usings



namespace ScriptsLib
{
	public static class Lang
	{
		public static void LoadLang(LangsList _Lang)
		{
			switch (_Lang)
			{
				case LangsList.English:
					Language = en_EN.Language;
					ErrorTitle = en_EN.ErrorTitle;
					ErrorSocketException = en_EN.ErrorSocketException;
					break;
				case LangsList.Português:
					Language = pt_PT.Language;
					ErrorTitle = pt_PT.ErrorTitle;
					ErrorSocketException = pt_PT.ErrorSocketException;
					break;
			}
		}

		public enum LangsList
		{
			English,
			Português,
		}



		internal static string Language { get; set; }
		internal static string ScriptsLibTitle { get; set; }
		internal static string ErrorTitle { get; set; }
		internal static string ErrorSocketException { get; set; }
	}
}
