﻿using System;

namespace ScriptsLibR.Extensions
{
	public static class ObjectExtensions
	{
		public static void ThrowArgumentNullExceptionIfNull(this object obj, string paramName, bool ignoreSpacesIfString)
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

			ThrowArgumentNullExceptionIfNull(obj, paramName);
		}

		public static void ThrowArgumentNullExceptionIfNull(this object obj, string paramName)
		{
			if (obj != null)
			{
				return;
			}

			throw new ArgumentNullException(paramName);
		}

		public static void ThrowArgumentNullExceptionIfTrue(this bool condition, string paramName)
		{
			if (condition)
			{
				throw new ArgumentNullException(paramName);
			}
		}
	}
}