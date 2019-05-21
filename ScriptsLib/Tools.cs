#region Usings
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Database;
using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Tools
{
	public class Tools
	{
		Debug debug = new Debug();












		#region Crash
		// # ================================================================================================ #
		private int _Variable { get; set; }

		public async Task Crash()
		{
			_Variable++;
			await Crash();
		}
		// # ================================================================================================ #
		#endregion Crash



		#region Check Login
		// # ================================================================================================ #
		public bool CheckLogin(string _Table, string _Username, string _Password, string _UsernameColumn, string _PasswordColumn)
		{
			SqlConnection _Connection = new SqlConnection(SlDatabase._BaseConnection + SlDatabase._DatabasePath);


			SqlCommand _Command = new SqlCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

			_Connection.OpenAsync().GetAwaiter().GetResult();
			int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

			debug.Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", "CheckLogin");

			_Connection.Close();
			
			if (_Result > 0)
			{
				return true;
			}
			return false;
		}
		// # ================================================================================================ #
		#endregion Check Login



		#region Password Generator
		public string PasswordGenerator(int _Size, string _Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
		{
			string _Password = null;
			Random _Random = new Random();
			while (_Size > 0)
			{
				_Size--;
				_Password = $"{_Password}{_Chars[_Random.Next(_Chars.Length)]}";
			}
			return _Password;
		}
		#endregion Password Generator


		
		#region ComboBox Resize
		///
		// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
		///


		[DllImport("user32.dll")]
		static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
		private const int CB_SETITEMHEIGHT = 0x153;

		public void ResizeCombobox(ComboBox _ComboBox, int _Hight)
		{
			SendMessage(_ComboBox.Handle, CB_SETITEMHEIGHT, -1, _Hight - 6);
			_ComboBox.Refresh();
		}
		#endregion ComboBox Resize



		#region SqlFilter
		public string SqlFilter(string _String)
		{
			_String = _String.Replace("'", null);
			_String = _String.Replace(";", null);

			return _String;
		}
		#endregion SqlFilter
	}
}