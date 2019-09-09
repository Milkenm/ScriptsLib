#region Usings
using System.Numerics;
#endregion Usings



namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Returns the number of combinations possible with the given elements and group.</summary>
		/// <param name="_Elements">How many elements to choose...</param>
		/// <param name="_Group">...from a group of?</param>
		public static BigInteger CalculateCombinations(BigInteger _Elements, BigInteger _Group)
		{
			if (CalculateFactorial(_Group - _Elements) == 0)
			{
				return 1;
			}
			else
			{
				return CalculateFactorial(_Group) / (CalculateFactorial(_Elements) * CalculateFactorial(_Group - _Elements));
			}
		}
	}
}
