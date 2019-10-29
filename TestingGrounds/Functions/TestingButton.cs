#region Usings
using System;

using static TestingGrounds.Values;
using static TestingGrounds.Testing;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void TestingButton()
		{
			try
			{
				switch (_MainForm.numeric_tg_testingIndex.Value)
				{
					case 0:
						RandomTesting(); break;
					case 1:
						Testing1(); break;
					case 2:
						Testing2(); break;
					case 3:
						Testing3(); break;
					case 4:
						Testing4(); break;
					case 5:
						Testing5(); break;
					case 6:
						Testing6(); break;
					case 7:
						Testing7(); break;
					case 8:
						Testing8(); break;
					case 9:
						Testing9(); break;
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
