#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Testing
	{
		/// <summary>Get Type (for DynVars).</summary>
		internal static void Testing5()
		{
			Type _Type1 = Type.GetType("int");
			Type _Type2 = Type.GetType("System.Int32");
			Type _Type3 = Type.GetType("System.String");

			MessageBox.Show($"Types:\n	1 > {_Type1}\n	2 > {_Type2}\n	3 > {_Type3}");
		}
	}
}
