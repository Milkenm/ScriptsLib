using System.Data.OleDb;

using static ScriptsLib.Dev;



namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		public static OleDbDataReader ExecuteSQL(string sql)
		{
			OleDbConnection con = new OleDbConnection(_BaseConnection + _DatabasePath);

			OleDbCommand command;
			command = new OleDbCommand(sql, con);

			Msg(command.CommandText, MsgType.Info, "Access ExecuteSQL");
			
			con.Open();
			OleDbDataReader dr = command.ExecuteReader();
			con.Close();

			return dr;
		}
	}
}