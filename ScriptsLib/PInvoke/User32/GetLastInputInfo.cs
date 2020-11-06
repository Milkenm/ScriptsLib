using System.Runtime.InteropServices;

namespace ScriptsLib.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		internal static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

		[StructLayout(LayoutKind.Sequential)]
		internal struct LASTINPUTINFO
		{
			public uint cbSize;
			public int dwTime;
		}
	}
}
