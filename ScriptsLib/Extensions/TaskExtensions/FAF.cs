using System;
using System.Threading.Tasks;

namespace ScriptsLib.Extensions
{
	public static class TaskExtensions
	{
		/// <summary>
		/// Fire-and-forget!
		/// </summary>
		public static void FAF(this Task task)
		{
			task.ContinueWith(t => { Console.WriteLine(t.Exception); }, TaskContinuationOptions.OnlyOnFaulted);
		}
	}
}
