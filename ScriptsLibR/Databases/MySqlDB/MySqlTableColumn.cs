using ScriptsLibR.Interfaces.Abstract;

namespace ScriptsLibR.Databases
{
	public class MySqlTableColumn : DatabaseTableColumn<MySqlDataType>
	{
		public MySqlTableColumn(string name, MySqlDataType dataType, bool isPrimaryKey, string parameters) : base(name, dataType, isPrimaryKey, parameters)
		{
			// base()
		}

		public MySqlTableColumn(string name, MySqlDataType dataType, string parameters) : base(name, dataType, false, parameters)
		{
			// base()
		}

		public MySqlTableColumn(string name, MySqlDataType dataType, bool isPrimaryKey) : base(name, dataType, isPrimaryKey, null)
		{
			// base()
		}

		public MySqlTableColumn(string name, MySqlDataType dataType) : base(name, dataType, false, null)
		{
			// base()
		}

		public MySqlTableColumn(string name, bool isPrimaryKey) : base(name, MySqlDataType.Number, isPrimaryKey, null)
		{
			// base()
		}

		public MySqlTableColumn(string name) : base(name, MySqlDataType.Number, false, null)
		{
			// base()
		}
	}

	// https://blog.devart.com/mysql-data-types.html#data_types_in_mysql
	public enum MySqlDataType
	{
		#region Integer

		TinyInt,
		SmallInt,
		MediumInt,
		Int,
		BigInt,
		Bit,

		#endregion Integer

		#region Real

		Float,
		Double,
		Decimal,

		#endregion Real

		#region Text

		/// <summary>Maximum number of characters: 65,535 characters (64 KB)</summary>
		VarChar,

		/// <summary>Maximum number of characters: 255 characters (255 B)</summary>
		Char,

		/// <summary>Maximum number of characters: 255 characters (255 B)</summary>
		TinyText,

		/// <summary>Maximum number of characters: 65,535 characters (64 KB)</summary>
		Text,

		/// <summary>Maximum number of characters: 16,777,215 characters (16 MB)</summary>
		MediumText,

		/// <summary>Maximum number of characters: 4,294,967,295 characters (4 GB)</summary>
		LongText,

		Json,

		#endregion Text

		#region Binary

		/// <summary>Maximum number of bytes: 255 bytes (255 B)</summary>
		Binary,

		/// <summary>Maximum number of bytes: 65,535 bytes (64 KB)</summary>
		VarBinary,

		/// <summary>Maximum size: 255 bytes</summary>
		TinyBlob,

		/// <summary>Maximum size: 65,535 bytes (64 KB)</summary>
		Blob,

		/// <summary>Maximum size: 16,777,215 bytes (16 MB)</summary>
		MediumBlob,

		/// <summary>Maximum size: 4,294,967,295 (4 GB)</summary>
		LongBlob,

		#endregion Binary

		#region Time

		Date,
		Time,
		Year,
		DateTime,
		Timestamp,

		#endregion Time

		#region Spatial (Geometry)

		Point,
		LineString,
		Polygon,
		Geometry,
		MultiPoint,
		MultiLineString,
		MultiPolygon,
		GeometryCollection,

		#endregion Spatial (Geometry)

		#region Other

		Unknown,

		/// <summary>Maximum number of values: 65,535 values</summary>
		Enum,

		/// <summary>Maximum number of values: 64 values</summary>
		Set,

		#endregion Other
	}
}