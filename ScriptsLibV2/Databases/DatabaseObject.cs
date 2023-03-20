using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace ScriptsLibV2.Databases
{
	public abstract class DatabaseObject
	{
		private long? Id;
		private readonly IDatabase DbEngine;
		private readonly string TableName;

		public DatabaseObject(IDatabase dbEgine, string tableName)
		{
			DbEngine = dbEgine;
			TableName = tableName;
		}

		public List<(Getter, MethodInfo)> GetGetters()
		{
			List<(Getter, MethodInfo)> getters = new List<(Getter, MethodInfo)>();
			foreach (MethodInfo method in GetType().GetMethods())
			{
				Getter getter = method.GetCustomAttribute<Getter>();
				if (getter != null)
				{
					getters.Add((getter, method));
				}
			}
			return getters;
		}

		public List<(Setter, MethodInfo)> GetSetters()
		{
			List<(Setter, MethodInfo)> setters = new List<(Setter, MethodInfo)>();
			foreach (MethodInfo method in GetType().GetMethods())
			{
				Setter setter = method.GetCustomAttribute<Setter>();
				if (setter != null)
				{
					setters.Add((setter, method));
				}
			}
			return setters;
		}

		public string GetTableName()
		{
			return TableName;
		}

		public long SaveToDatabase()
		{
			// Get table fields
			List<(Getter, MethodInfo)> gettersList = GetGetters();

			// Create command
			DbCommand cmd = DbEngine.CreateCommand();

			if (Id == null)
			{
				// Store columns and parameters
				StringConnector sbColumns = new StringConnector();
				StringConnector sbParameters = new StringConnector();
				List<DbParameter> parametersList = new List<DbParameter>();

				// Add columns and parameters to the lists
				foreach ((Getter, MethodInfo) getter in gettersList)
				{
					// Store columns
					string columnName = getter.Item1.ColumnName;
					sbColumns.Append(columnName);
					sbParameters.Append($"@{columnName}");

					// Store parameters
					DbParameter parameter = cmd.CreateParameter();
					parameter.ParameterName = $"@{columnName}";
					parameter.Value = getter.Item2.Invoke(this, null);
					parametersList.Add(parameter);
				}
				// Join all columns with ","
				sbColumns.AddJoiner(",");
				sbParameters.AddJoiner(",");

				// Create SQL command
				cmd.CommandText = $"INSERT INTO {TableName} ({sbColumns}) VALUES ({sbParameters})";
				// Add parameters value to SQL
				foreach (DbParameter parameter in parametersList)
				{
					cmd.Parameters.Add(parameter);
				}

				// Run command
				DbEngine.ExecuteNonQuery(cmd);

				// Get created ID
				Id = DbEngine.GetLastRowId(TableName);
			}
			else
			{
				StringConnector sbColumns = new StringConnector();

				// Create update SQL
				foreach ((Getter, MethodInfo) getter in gettersList)
				{
					string columnName = getter.Item1.ColumnName;
					sbColumns.Append($"{columnName}=@{columnName}");
				}
				sbColumns.AddJoiner(", ");
				cmd.CommandText = $"UPDATE {TableName} SET {sbColumns} WHERE ID={Id}";

				// Set parameters
				foreach ((Getter, MethodInfo) getter in gettersList)
				{
					string columnName = getter.Item1.ColumnName;

					DbParameter parameter = cmd.CreateParameter();
					parameter.ParameterName = $"@{columnName}";
					parameter.Value = getter.Item2.Invoke(this, null);
					cmd.Parameters.Add(parameter);
				}

				// Run command
				DbEngine.ExecuteNonQuery(cmd);
			}

			return (long)Id;
		}


		public void LoadFromDatabase(long id)
		{
			// Select row
			DataTable row = DbEngine.Select(TableName, condition: $"ID={id}");

			// Get values from database and call the setter
			foreach ((Setter, MethodInfo) setter in GetSetters())
			{
				object dbValue = row.Rows[0][setter.Item1.ColumnName];
				setter.Item2.Invoke(this, new object[] { dbValue });
			}

			Id = id;
		}

		public void DeleteFromDatabase()
		{
			if (Id == null)
			{
				return;
			}

			DbEngine.Delete(TableName, $"ID={Id}");
		}
	}
}