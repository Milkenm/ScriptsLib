namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Returns <see langword="true"/> if the provided number is prime, else returns <see langword="false"/>.</summary>
		/// <param name="number">The number to check.</param>
		public static bool IsPrimeNumber(int number)
		{
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return number > 1;
		}
	}
}
