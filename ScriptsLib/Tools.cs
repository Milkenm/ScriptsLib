#region Usings
using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Databases;
using ScriptsLib.Dev;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Tools
{
	public class Tools
	{
		Debug _Debug = new Debug();









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
		public bool CheckLogin(string _Table, string _Username, string _Password, string _UsernameColumn, string _PasswordColumn, DatabaseType _DatabaseType)
		{
			try
			{
				if (_DatabaseType == DatabaseType.SqlServer)
				{
					SqlConnection _Connection = new SqlConnection(SqlServer_Database._BaseConnection + SqlServer_Database._DatabasePath);


					SqlCommand _Command = new SqlCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					_Debug.Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else if (_DatabaseType == DatabaseType.Access)
				{
					OleDbConnection _Connection = new OleDbConnection(Access_Database._BaseConnection + Access_Database._DatabasePath);


					OleDbCommand _Command = new OleDbCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					_Debug.Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else
				{
					throw new Exception();
				}
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return false;
			}
		}



		public enum DatabaseType
		{
			SqlServer,
			Access,
		}
		// # ================================================================================================ #
		#endregion Check Login



		#region Password Generator
		public string PasswordGenerator(int _Size, string _Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
		{
			try
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
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
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
			try
			{
				SendMessage(_ComboBox.Handle, CB_SETITEMHEIGHT, -1, _Hight - 6);
				_ComboBox.Refresh();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		#endregion ComboBox Resize



		#region SqlFilter
		public string SqlFilter(string _String)
		{
			try
			{
				_String = _String.Replace("'", null);
				_String = _String.Replace(";", null);

				return _String;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		#endregion SqlFilter



		#region Hash
		///
		// https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
		///


		public string Hash(string _String)
		{
			try
			{
				HashAlgorithm _Hash = SHA256.Create();
				StringBuilder _Builder = new StringBuilder();

				foreach (byte _Byte in _Hash.ComputeHash(Encoding.UTF8.GetBytes(_String)))
				{
					_Builder.Append(_Byte.ToString("X2"));
				}

				return _Builder.ToString();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		#endregion Hash
	}
}