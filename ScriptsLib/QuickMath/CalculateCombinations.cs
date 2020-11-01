using System.Numerics;

namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Returns the number of combinations possible with the given elements and group.</summary>
		/// <param name="elements">How many elements to choose...</param>
		/// <param name="group">...from a group of?</param>
		public static BigInteger CalculateCombinations(BigInteger elements, BigInteger group)
		{
			if (CalculateFactorial(group - elements) == 0)
			{
				return 1;
			}
			else
			{
				return CalculateFactorial(group) / (CalculateFactorial(elements) * CalculateFactorial(group - elements));
			}
		}
	}
}
