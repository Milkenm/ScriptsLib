namespace ScriptsLibR.Databases.MySql.Types
{
	// https://blog.devart.com/mysql-data-types.html#data_types_in_mysql
	public enum MySqlDataType
	{
		// INTEGER
		SmallInt,
		MediumInt,
		BigInt,

		// REAL
		Float,
		Double,
		Decimal,

		// TEXT
		/// <summary>Maximum number of characters: 65,535 characters (64 KB)</summary>
		VarChar,
		/// <summary>Maximum number of characters: 255 characters (255 B)</summary>
		Char,
		/// <summary>Maximum number of characters: 255 characters (255 B)</summary>
		TinyText,
		/// <summary>Maximum number of characters: 16,777,215 characters (16 MB)</summary>
		MediumText,
		/// <summary>Maximum number of characters: 4,294,967,295 characters (4 GB)</summary>
		LongText,
		Json,

		// BINARY
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

		// TIME
		Date,
		Time,
		Year,
		DateTime,
		Timestamp,

		// SATIAL (GEOMETRY)
		Point,
		LineString,
		Polygon,
		Geometry,
		MultiPoint,
		MultiLineString,
		MultiPolygon,
		GeometryCollection,

		// OTHER
		Unknown,
		/// <summary>Maximum number of values: 65,535 values</summary>
		Enum,
		/// <summary>Maximum number of values: 64 values</summary>
		Set,
	}
}
