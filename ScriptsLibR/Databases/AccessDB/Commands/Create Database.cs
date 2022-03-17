using ScriptsLibR.Exceptions;

using System.IO;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int[] CreateDatabase(string filePath)
		{
			if (File.Exists(filePath))
			{
				throw new FileAlreadyExistsException(filePath);
			}

			string dbName = Path.GetFileNameWithoutExtension(filePath);

			string[] sqls = new string[]
			{
				$"CREATE DATABASE {dbName} ON PRIMARY (NAME={dbName}, FILENAME='{filePath}')",
				$"EXEC sp_detach_db '{dbName}', 'true'"
			};
			return this.ExecuteNonQuery(sqls, false);
		}

		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="filePath">The path (including the file name and extension) where the database will be created.</param>
		public async Task<int[]> CreateDatabaseAsync(string filePath)
		{
			if (File.Exists(filePath))
			{
				throw new FileAlreadyExistsException(filePath);
			}

			string dbName = Path.GetFileNameWithoutExtension(filePath);

			string[] sqls = new string[]
			{
				$"CREATE DATABASE {dbName} ON PRIMARY (NAME={dbName}, FILENAME='{filePath}')",
				$"EXEC sp_detach_db '{dbName}', 'true'",
			};
			return await this.ExecuteNonQueryAsync(sqls, false);
		}
	}
}
