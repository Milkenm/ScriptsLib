using System;

namespace ScriptsLibV2.Extensions
{
	public static partial class ObjectExtensions
	{
		public static void ThrowExceptionIfNull(this object obj, string paramName, bool ignoreSpacesIfString)
		{
			if (obj.GetType() == typeof(string))
			{
				bool isNull = ((string)obj).IsEmpty(ignoreSpacesIfString);
				if (!isNull)
				{
					return;
				}
				throw new ArgumentNullException(paramName);
			}
			else if (obj.GetType() == typeof(string[]))
			{
				bool isNull = ((string[])obj).IsEmpty(ignoreSpacesIfString);
				if (!isNull)
				{
					return;
				}
				throw new ArgumentNullException(paramName);
			}

			ThrowExceptionIfNull(obj, paramName);
		}

		public static void ThrowExceptionIfNull(this object obj, string paramName)
		{
			if (obj != null)
			{
				return;
			}

			throw new ArgumentNullException(paramName);
		}
	}
}
