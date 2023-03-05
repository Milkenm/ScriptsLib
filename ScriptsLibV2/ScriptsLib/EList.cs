using System.Collections.Generic;

namespace ScriptsLibV2
{
	public class SList<T> : List<T>
	{
		public static SList<T> Of(params T[] values)
		{
			SList<T> list = new SList<T>();
			list.AddRange(values);
			return list;
		}
	}
}
