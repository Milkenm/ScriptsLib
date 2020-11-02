using System.Collections.Generic;
using System.Numerics;

namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Gets the factorial result of the given number.</summary>
		/// <param name="number">The number to get the factorial result from.</param>
		/// https://pt.wikipedia.org/wiki/Combina%C3%A7%C3%A3o
		public static BigInteger CalculateFactorial(BigInteger number)
		{
			List<BigInteger> splitFactorial = new List<BigInteger>();
			BigInteger result = 0;

			while (number > 0)
			{
				splitFactorial.Add(number);
				number--;
			}
			foreach (BigInteger mult in splitFactorial)
			{
				result = (result == 0)
					? mult
					: result * mult;
			}

			return result;
		}
	}
}