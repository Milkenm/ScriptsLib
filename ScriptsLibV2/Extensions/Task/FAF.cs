using System;
using System.Threading.Tasks;

namespace ScriptsLibV2.Extensions
{
	public static partial class TaskExtensions
	{
		/// <summary>
		/// Fire-and-forget!
		/// </summary>
		public static void FAF(this Task task)
		{
			task.ContinueWith(t => Console.WriteLine(t.Exception), TaskContinuationOptions.OnlyOnFaulted);
		}
	}
}