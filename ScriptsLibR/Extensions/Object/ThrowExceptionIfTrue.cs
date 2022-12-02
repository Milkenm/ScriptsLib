using System;

namespace ScriptsLibR.Extensions
{
	public static partial class ObjectExtensions
	{
		public static void ThrowExceptionIfTrue(this bool condition, string paramName)
		{
			if (condition)
			{
				throw new ArgumentNullException(paramName);
			}
		}
	}
}
