#region Usings
using System.Collections.Generic;
using System.Numerics;

using static ScriptsLib.Dev;
#endregion Usings

// # = #
// https://pt.wikipedia.org/wiki/Combina%C3%A7%C3%A3o
// # = #

namespace ScriptsLib
{
	public static partial class QuickMath
	{
		/// <summary>Gets the factorial result of the given number.</summary>
		/// <param name="_Number">The number to get the factorial result from.</param>
		public static BigInteger CalculateFactorial(BigInteger _Number)
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
					Msg($"_Result ({_Result}) = _Mult ({_Mult})", MsgType.Info);
					_Result = _Mult;
				}
				else
				{
					Msg($"_Result ({_Result * _Mult}) = _Result ({_Result}) * _Mult ({_Mult})", MsgType.Info);
					_Result = _Result * _Mult;
				}
			}
			Msg(_Result.ToString(), MsgType.Info);
			return _Result;
		}
	}
}
