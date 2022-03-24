﻿using Microsoft.Office.Interop.Access.Dao;

using ScriptsLibR.Exceptions;
using ScriptsLibR.Extensions;
using ScriptsLibR.Interfaces;

using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

namespace ScriptsLibR.Databases
{
	public partial class AccessDB : IDatabase
	{
		private static AccessDB Instance;

		public static AccessDB GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(Instance);
			}
			return Instance;
		}

		public AccessDB(string connectionString)
		{
			Utils.Utils.NullChecker((connectionString, nameof(connectionString)));
			Instance = this;

			this.ConnectionString = connectionString;

			if (!File.Exists(this.GetDatabasePath()))
			{
				this.CreateDatabase();
			}
		}

		public string GetDatabasePath()
		{
			string databasePath = null;
			foreach (string split in this.ConnectionString.Split(';'))
			{
				if (split.ToLower().Replace(" ", "").StartsWith("datasource=") && (split.ToLower().EndsWith(".mdb") || split.ToLower().EndsWith(".accdb")))
				{
					databasePath = split.Split('=')[1];
				}
			}
			return databasePath;
		}

		public static void CreateDatabase(string databasePath, DatabaseTypeEnum provider)
		{
			Utils.Utils.NullChecker(true, (databasePath, nameof(databasePath)), (provider, nameof(provider)));

			if (File.Exists(databasePath))
			{
				throw new FileAlreadyExistsException(databasePath);
			}

			// New database thing: https://stackoverflow.com/a/54896004
			string dbLangGeneral = ";LANGID=0x0409;CP=1252;COUNTRY=0";

			DBEngine engine = new DBEngine();
			Database dbs = engine.CreateDatabase(databasePath, dbLangGeneral, provider);
			dbs.Close();
			// This took me 4 days to fix because I had two different computers where one worked fine and the other didn't...
			// IDK what this does but it works (https://stackoverflow.com/a/14102594).
			// (The problem was that there was a process left that kept database files locked)
			Marshal.FinalReleaseComObject(engine);
			Marshal.FinalReleaseComObject(dbs);
		}

		public void CreateDatabase()
		{
			string databasePath = this.GetDatabasePath();
			DatabaseTypeEnum provider = this.GetProvider();
			CreateDatabase(databasePath, provider);
		}

		private OleDbConnection DbConnection;

		private OleDbConnection GetDbConnection()
		{
			if (DbConnection != null)
			{
				return DbConnection;
			}

			if (!this.GetDatabasePath().IsEmpty() && !File.Exists(this.GetDatabasePath()))
			{
				this.CreateDatabase();
			}
			DbConnection = new OleDbConnection(this.ConnectionString);
			if (DbConnection.State != ConnectionState.Open)
			{
				DbConnection.Open();
			}
			return DbConnection;
		}

		public void CloseConnection()
		{
			if (DbConnection != null && DbConnection.State == ConnectionState.Open)
			{
				DbConnection.Close();
			}
		}

		public const string DEFAULT_BASECONNECTION_JET40 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
		public const string DEFAULT_BASECONNECTION_ACE120 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
		public const string DEFAULT_BASECONNECTION_ACE150 = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=";

		/// <summary>
		/// The provider and stuff to connect to the database.
		/// <para>Visit <see href="https://www.connectionstrings.com/access/">ConnectionStrings.com</see> for more connection strings.</para>
		/// </summary>
		public string ConnectionString { get; } = DEFAULT_BASECONNECTION_ACE150;

		public DatabaseTypeEnum GetProvider(string connectionString)
		{
			if (connectionString.IsEmpty())
			{
				throw new Exception("Connection string is empty.");
			}
			string[] split = connectionString.Split(';');
			foreach (string s in split)
			{
				if (!s.ToLower().StartsWith("provider"))
				{
					continue;
				}

				// I have absolutly no idea what versions there are. I can't find anything anywhere so here is my guess...
				return s.ToLower().Replace(" ", "").Replace("provider=microsoft.", "") switch
				{
					// Jet
					"jet.oledb.4.0" => DatabaseTypeEnum.dbVersion40,
					"jet.oledb.3.0" => DatabaseTypeEnum.dbVersion30,
					"jet.oledb.2.0" => DatabaseTypeEnum.dbVersion20,
					"jet.oledb.1.1" => DatabaseTypeEnum.dbVersion11,
					"jet.oledb.1.0" => DatabaseTypeEnum.dbVersion10,
					// Access
					"ace.oledb.15.0" => DatabaseTypeEnum.dbVersion150,
					"ace.oledb.14.0" => DatabaseTypeEnum.dbVersion140,
					"ace.oledb.12.0" => DatabaseTypeEnum.dbVersion120,
					_ => throw new Exception($"Provider not recognized: '{s}'"),
				};
			}
			throw new Exception($"Connection string does not contain a provider.");
		}
		public DatabaseTypeEnum GetProvider()
		{
			return this.GetProvider(this.ConnectionString);
		}
	}
}