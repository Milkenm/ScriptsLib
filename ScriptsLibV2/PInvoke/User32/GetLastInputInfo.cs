using System.Runtime.InteropServices;

namespace ScriptsLibV2.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

		[StructLayout(LayoutKind.Sequential)]
		public struct LASTINPUTINFO
		{
			public uint cbSize;
			public int dwTime;
		}
	}
}
