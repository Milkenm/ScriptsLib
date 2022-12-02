using System;
using System.Threading.Tasks;

namespace ScriptsLibR.Extensions
{
	public static class TaskExtensions
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