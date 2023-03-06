using ScriptsLibV2.Exceptions;

namespace ScriptsLibV2.Extensions
{
	public class Instanciator<T>
	{
		private static readonly T Instance;

		public static T GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(typeof(T));
			}
			return Instance;
		}
	}
}
