using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static ScriptsLib.PInvoke.User32;

namespace ScriptsLib.Unsorted
{
	public class InputInactivity
	{
		/// <summary>Triggers an event after some time of user inactivity.</summary>
		/// <param name="msDelay">The time in milliseconds to trigger the inactivity event.</param>
		public InputInactivity(long msDelay = 0)
		{
			MsDelay = msDelay;

			Timer.Interval = 1;
			Timer.Tick += (s, e) => TimerTick();
			Timer.Start();
		}

		public delegate void EventDelegate();

		public event EventDelegate InputReceived;

		public event EventDelegate InactivityTimeReached;

		private readonly Timer Timer = new Timer();

		public long MsDelay { get; } = 0;

		private static bool DidRun;

		private void TimerTick()
		{
			DateTime bootTime = DateTime.UtcNow.AddMilliseconds(-Environment.TickCount);

			LASTINPUTINFO lii = new LASTINPUTINFO();
			lii.cbSize = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO));
			GetLastInputInfo(ref lii);

			DateTime lastInputTime = bootTime.AddMilliseconds(lii.dwTime);

			TimeSpan idleTime = DateTime.UtcNow.Subtract(lastInputTime);

			if (MsDelay > 0)
			{
				long msIdle = idleTime.Milliseconds + (idleTime.Seconds * 1000) + (idleTime.Minutes * 60000) + (idleTime.Hours * 3600000) + (idleTime.Days * 86400000);

				if (msIdle == MsDelay)
				{
					DidRun = true;
					InactivityTimeReached();
				}
				if (msIdle < MsDelay && DidRun)
				{
					DidRun = false;
					InputReceived();
				}
			}
		}
	}
}