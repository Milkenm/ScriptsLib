#region Usings
using System;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="_Path">The path where the database will be created.</param>
		public static async Task CreateDatabase(string _Path)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					if (!File.Exists(_Path))
					{
						string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

						OleDbConnection _Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;");
						_Connection.OpenAsync();
						OleDbCommand _Command = _Connection.CreateCommand();


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
