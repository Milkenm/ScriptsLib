using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		public static Assembly? GetAssemblyByName(string assemblyName)
		{
			IEnumerable<Assembly> matchingAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assembly.GetName().Name == assemblyName);

			if (matchingAssemblies.Any())
			{
				return matchingAssemblies.ElementAt(0);
			}
			return null;
		}
	}
}
