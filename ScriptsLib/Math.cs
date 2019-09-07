#region Usings
using System.Collections.Generic;
using System.Numerics;
#endregion Usings



namespace ScriptsLib.Math
{
	public class Math
	{
		#region Calculate Combinations
		// # ================================================================================================ #
		/// <summary>Returns the number of combinations possible with the given elements and group.</summary>
		/// <param name="_Elements">How many elements to choose...</param>
		/// <param name="_Group">...from a group of?</param>
		public BigInteger CalculateCombinations(BigInteger _Elements, BigInteger _Group)
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
		// # ================================================================================================ #
		#endregion Calculate Combinations


		#region Calculate Factorial
		// # ================================================================================================ #
		///
		// https://pt.wikipedia.org/wiki/Combina%C3%A7%C3%A3o
		///

		/// <summary>Gets the factorial result of the given number.</summary>
		/// <param name="_Number">The number to get the factorial result from.</param>
		public BigInteger CalculateFactorial(BigInteger _Number)
		{
			List<BigInteger> _SplitFactorial = new List<BigInteger>();
			BigInteger _Result = 0;

			while (_Number > 0)
			{
				_SplitFactorial.Add(_Number);
				_Number--;
			}
			foreach (BigInteger _Mult in _SplitFactorial)
			{
				if (_Result == 0)
				{
					System.Windows.Forms.MessageBox.Show($"_Result ({_Result}) = _Mult ({_Mult})");
					_Result = _Mult;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show($"_Result ({_Result * _Mult}) = _Result ({_Result}) * _Mult ({_Mult})");
					_Result = _Result * _Mult;
				}
			}
			System.Windows.Forms.MessageBox.Show(_Result.ToString());
			return _Result;
		}
		// # ================================================================================================ #
		#endregion Calculate Factorial


		#region Is Prime Number
		// # ================================================================================================ #
		/// <summary>Returns <see langword="true"/> if the provided number is prime, else returns <see langword="false"/>.</summary>
		/// <param name="_Number">The number to check.</param>
		public bool IsPrimeNumber(int _Number)
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
		// # ================================================================================================ #
		#endregion Is Prime Number
	}
}
