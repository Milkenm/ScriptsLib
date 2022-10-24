using System;

namespace ScriptsLibR.Exceptions
{
	public class InvalidDataTypeException : Exception
	{
		public InvalidDataTypeException() { }

		public InvalidDataTypeException(Type dataType) : base($"The data type '{dataType.Name}' is not valid.") { }

		public InvalidDataTypeException(Type dataType, Exception inner) : base($"The data type '{dataType.Name}' is not valid.", inner) { }
	}
}
