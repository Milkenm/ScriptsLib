#region Usings
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib
{
	public class DynVars
	{
		public static string _DynvarsFilePath { get; set; }

		public dynamic DynVar(string _Variable, dynamic _Value = null)
		{
			#region Exceptions
			if (!String.IsNullOrEmpty(_Variable) && _Variable.Contains("=") || !String.IsNullOrEmpty(_Value) && _Value.Contains("="))
			{
				throw new Exception("DynVars: Variables/Values cannot contain equal signs.");
			}
			if (String.IsNullOrEmpty(_Variable))
			{
				throw new Exception("DynVars: Variable name is empty.");
			}
			#endregion Exceptions

			#region Generate DynVars File and Path
			if (String.IsNullOrEmpty(_DynvarsFilePath))
			{
				_DynvarsFilePath = Info.Info._UserdataPath + "DynVars.txt";
			}
			if (!File.Exists(_DynvarsFilePath))
			{
				File.WriteAllText(_DynvarsFilePath, $"ScriptsLib (v{Info.Info._Version}) DynVars File. Please do not modify.\n\n\n\n");
			}
			#endregion Generate DynVars File and Path


			
			if (String.IsNullOrEmpty(_Value)) // Get variable value.
			{
				if (File.ReadAllText(_DynvarsFilePath).Contains($"\n{_Variable}=")) // If the variable exists.
				{
					foreach (string _Line in File.ReadAllLines(_DynvarsFilePath))
					{
						if ($"\n{_Line}".Contains($"\n{_Variable}=")) // If the line contains the variable.
						{
							return new Tools.Tools().ReplaceString(_Line, _Variable + "=", "");
						}
					}
				}
			}
			else // Sets a variable.
			{
				if (File.ReadAllText(_DynvarsFilePath).Contains($"\n{_Variable}=")) // If the variable exists.
				{
					string[] _Lines = File.ReadAllLines(_DynvarsFilePath);
					int _Index = 0;
					foreach (string _Line in File.ReadAllLines(_DynvarsFilePath))
					{
						_Index++;
						if ($"\n{_Line}".Contains($"\n{_Variable}=")) // If the line contains the variable.
						{
							_Lines[_Index - 1] = $"{_Variable}={_Value}";
						}
					}
					File.Delete(_DynvarsFilePath);
					string _Text = null;
					foreach (string _Line in _Lines)
					{
						if (String.IsNullOrEmpty(_Text))
						{
							_Text = _Line;
						}
						else
						{
							_Text = $"{_Text}\n{_Line}";
						}
					}
					File.WriteAllText(_DynvarsFilePath, _Text);
				}
				else // If the file doesn't contain the variable.
				{
					string _FileContent = File.ReadAllText(_DynvarsFilePath);
					_FileContent = $"{_FileContent}\n{_Variable}={_Value}";
					File.Delete(_DynvarsFilePath);
					File.WriteAllText(_DynvarsFilePath, _FileContent);
				}
			}
			return null;
		}
	}
}
