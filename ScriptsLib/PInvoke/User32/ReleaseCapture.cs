using System.Runtime.InteropServices;

namespace ScriptsLib.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
	}
}
