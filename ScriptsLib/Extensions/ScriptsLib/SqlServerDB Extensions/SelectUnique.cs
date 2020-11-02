using ScriptsLib.Databases;

using System.Collections.Generic;
using System.Data;

namespace ScriptsLib.Extensions.ScriptsLib
{
	public static partial class SqlServerDBExtensions
	{
		/// <summary>Returns one of each value from a column. Returns an empty list is nothing is found.</summary>
		/// <param name="table">The table to search.</param>
		/// <param name="column">The table column to search.</param>
		public static List<object> SelectUnique(this SqlServerDB db, string table, string column)
		{
			DataTable selection = db.Select(table, column);

			if (selection.Rows.Count > 0)
			{
				List<object> values = new List<object>();
				foreach (DataRow r in selection.Rows)
				{
					if (!values.Contains(r[0]))
					{
						values.Add(r[0]);
					}
				}
				return values;
			}
			else
			{
				return new List<object>();
			}
		}
	}
}