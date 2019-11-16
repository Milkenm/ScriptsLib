#region Usings
using System;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Get current time and date. ([DD] Day || [MM] Month || [YYYY] Year || [hh] - Hour || [mm] Minute || [ss] Second || [ms] Millisecond.</summary>
		/// <param name="_Format">The format to return the date.</param>
		public static string GetDate(string _Format = "DD/MM/YYYY - hh:mm:ss (.ms)")
		{
			string _Day = DateTime.Now.Day.ToString();
			string _Month = DateTime.Now.Month.ToString();
			string _Year = DateTime.Now.Year.ToString();
			string _Hour = DateTime.Now.Hour.ToString();
			string _Minute = DateTime.Now.Minute.ToString();
			string _Second = DateTime.Now.Second.ToString();
			string _Millisecond = DateTime.Now.Millisecond.ToString();



			if (_Day.Length < 2)
			{
				_Day = 0 + _Day;
			}
			if (_Month.Length < 2)
			{
				_Month = 0 + _Month;
			}
			if (_Hour.Length < 2)
			{
				_Hour = 0 + _Hour;
			}
			if (_Minute.Length < 2)
			{
				_Minute = 0 + _Minute;
			}
			if (_Second.Length < 2)
			{
				_Second = 0 + _Second;
			}

			if (_Millisecond.Length < 2)
			{
				_Millisecond = 00 + _Millisecond;
			}
			else if (_Millisecond.Length < 3)
			{
				_Millisecond = 0 + _Millisecond;
			}



			return _Format.Replace("DD", _Day).Replace("MM", _Month).Replace("YYYY", _Year).Replace("hh", _Hour).Replace("mm", _Minute).Replace("ss", _Second).Replace("ms", _Millisecond);
		}
	}
}
