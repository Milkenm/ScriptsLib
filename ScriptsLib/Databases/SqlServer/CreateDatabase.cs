#region Usings
using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class SqlServerDatabase
	{
		public static async Task CreateDatabase(string _Path)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					if (!File.Exists(_Path))
					{
						string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

						SqlConnection _Connection = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true");
						_Connection.OpenAsync();
						SqlCommand _Command = _Connection.CreateCommand();


						_Command.CommandText = $"CREATE DATABASE {_DatabaseName} ON PRIMARY (NAME={_DatabaseName}, FILENAME='{_Path}')";
						Msg(_Command.CommandText, MsgType.Info, "Create Database");
						_Command.ExecuteNonQueryAsync();

						_Command.CommandText = $"EXEC sp_detach_db '{_DatabaseName}', 'true'";
						Msg(_Command.CommandText, MsgType.Info, "Export Database");
						_Command.ExecuteNonQueryAsync();

						_Connection.Close();
					}
					else
					{
						throw new Exception("File already exists!");
					}
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
