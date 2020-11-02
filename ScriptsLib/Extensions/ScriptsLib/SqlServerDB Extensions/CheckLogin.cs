using ScriptsLib.Databases;

using System.Data;

namespace ScriptsLib.Extensions.ScriptsLib
{
	public static partial class SqlServerDBExtensions
	{
		/// <summary>Checks if the given user and password exist in the database.</summary>
		/// <param name="table">The database table containing the user accounts.</param>
		/// <param name="usernameColumn">The table column containing the usernames.</param>
		/// <param name="passwordColumn">The table column containing the passwords.</param>
		/// <param name="username">The given username to be checked.</param>
		/// <param name="password">The given password to be checked.</param>
		public static bool CheckLogin(this SqlServerDB db, string table, string usernameColumn, string passwordColumn, string username, string password)
		{
			DataTable selection = db.Select(table, "COUNT (*)", $"{usernameColumn}='{username}' AND {passwordColumn}='{password}'");
			return selection.Rows.Count > 0;
		}
	}
}