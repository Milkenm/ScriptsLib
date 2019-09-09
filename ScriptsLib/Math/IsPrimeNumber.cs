namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Returns <see langword="true"/> if the provided number is prime, else returns <see langword="false"/>.</summary>
		/// <param name="_Number">The number to check.</param>
		public static bool IsPrimeNumber(int _Number)
		{
			for (var _Loop = 2; _Loop < _Number; _Loop++)
			{
				if (_Number % _Loop == 0)
				{
					return false;
				}
			}
			return _Number > 1;
		}
	}
}
