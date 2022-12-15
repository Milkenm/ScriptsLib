using ScriptsLibR.Extensions;

using System;
using System.Threading.Tasks;

namespace ScriptsLibR.Util
{
	public static partial class Utils
	{
		public static void NullChecker(Action<string> nullAction, bool takeEmptyStringAsNull, params (object parameter, string parameterName)[] objectsList)
		{
			foreach ((object parameter, string parameterName) obj in objectsList)
			{
				if (obj.parameter == null || (obj.parameter is string objString && takeEmptyStringAsNull && objString.IsEmpty()))
				{
					nullAction?.Invoke(obj.parameterName);
				}
			}
		}

		public static void NullChecker(Action<string> nullAction, params (object parameter, string parameterName)[] objectsList)
		{
			NullChecker(nullAction, false, objectsList);
		}

		public static void NullChecker(bool takeEmptyStringAsNull, params (object parameter, string parameterName)[] objectsList)
		{
			Action<string> action = new Action<string>((name) =>
			{
				throw new ArgumentNullException(name);
			});
			NullChecker(action, takeEmptyStringAsNull, objectsList);
		}

		public static void NullChecker(params (object parameter, string parameterName)[] objectsList)
		{
			NullChecker(false, objectsList);
		}

		public static async Task NullCheckerAsync(Func<string, Task> asyncNullAction, bool takeEmptyStringAsNull, params (object parameter, string parameterName)[] objectsList)
		{
			foreach ((object parameter, string parameterName) obj in objectsList)
			{
				if (obj.parameter == null || (obj.parameter is string objString && takeEmptyStringAsNull && objString.IsEmpty()))
				{
					await asyncNullAction?.Invoke(obj.parameterName);
				}
			}
		}

		public static async Task NullCheckerAsync(Func<string, Task> asyncNullAction, params (object parameter, string parameterName)[] objectsList)
		{
			await NullCheckerAsync(asyncNullAction, false, objectsList);
		}

		public static async Task NullCheckerAsync(bool takeEmptyStringAsNull, params (object parameter, string parameterName)[] objectsList)
		{
			Func<string, Task> asyncAction = new Func<string, Task>((name) =>
		   {
			   throw new ArgumentNullException(name);
		   });
			await NullCheckerAsync(asyncAction, takeEmptyStringAsNull, objectsList);
		}

		public static async Task NullCheckerAsync(params (object parameter, string parameterName)[] objectsList)
		{
			await NullCheckerAsync(false, objectsList);
		}
	}
}