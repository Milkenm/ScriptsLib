using ScriptsLibR.Exceptions;
using ScriptsLibR.Extensions;

using System.IO;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServerDB
{
	public partial class SqlServerDB
	{
		public int[] CreateDatabase(string filePath)
		{
			string[] sqls = this.CreateDatabaseCode(filePath);
			return this.ExecuteNonQuery(sqls, false);
		}

		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="filePath">The path (including the file name and extension) where the database will be created.</param>
		public async Task<int[]> CreateDatabaseAsync(string filePath)
		{
			string[] sqls = this.CreateDatabaseCode(filePath);
			return await this.ExecuteNonQueryAsync(sqls, false);
		}

		private string[] CreateDatabaseCode(string filePath)
		{
			filePath.ThrowArgumentNullExceptionIfNull("filePath", true);
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
