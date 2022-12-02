using System.Threading.Tasks;

namespace ScriptsLibR.Utils
{
	public static partial class Utils
	{
		/// <summary>Crashes your application (this is useless no?).</summary>
		public static async Task Crash()
		{
			await Crash().ConfigureAwait(false);
		}
	}
}