#region Usings
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

using ScriptsLib.Database;
using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Tools
{
	public class Tools
	{
		Debug debug = new Debug();












		#region Crash
		private int _Variable { get; set; }

		public async Task Crash()
		{
			_Variable++;
			await Crash();
		}
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
	}
}
