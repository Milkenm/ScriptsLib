using System.IO;
using System.Threading.Tasks;

using ScriptsLibR.Exceptions;
using ScriptsLibR.Util;

namespace ScriptsLibR.Databases
{
	public partial class SqlServerDB
	{
		public int[] CreateDatabase(string filePath)
		{
			string[] sqls = CreateDatabaseCode(filePath);
			return ExecuteNonQuery(GetDatabaseConnection(), sqls);
		}

		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="filePath">The path (including the file name and extension) where the database will be created.</param>
		public async Task<int[]> CreateDatabaseAsync(string filePath)
		{
			string[] sqls = CreateDatabaseCode(filePath);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), sqls);
		}

		private string[] CreateDatabaseCode(string filePath)
		{
			Utils.NullChecker(true, (filePath, nameof(filePath)));

			if (File.Exists(filePath))
			{
				throw new FileAlreadyExistsException(filePath);
			}

			string dbName = Path.GetFileNameWithoutExtension(filePath);

			return new string[]
			{
				$"CREATE DATABASE {dbName} ON PRIMARY (NAME={dbName}, FILENAME='{filePath}')",
				$"EXEC sp_detach_db '{dbName}', 'true'",
			};
		}
	}
}