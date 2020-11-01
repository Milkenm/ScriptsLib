using System.Threading.Tasks;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Crashes your application (this is useless no?).</summary>
		public static async Task Crash()
		{
			await Crash().ConfigureAwait(false);
		}
	}
}
