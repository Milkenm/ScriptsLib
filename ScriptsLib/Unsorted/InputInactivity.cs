using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static ScriptsLib.PInvoke.User32;
using static ScriptsLib.Unsorted.Unsorted;

namespace ScriptsLib.Unsorted
{
	public class InputInactivity
	{
		/// <summary>Triggers an event after some time of user inactivity.</summary>
		/// <param name="delay">The time in milliseconds to trigger the inactivity event.</param>
		public InputInactivity(long delay = 0)
		{
			this.SetDelay(delay);

			this.t.Interval = 1;
			this.t.Tick += (s, e) => Tick();
			this.t.Start();

			DateTime d = new DateTime();
		}

		public delegate void InputInactivityEvent();
		public event InputInactivityEvent InputReceived;
		public event InputInactivityEvent InactivityTimeReached;

		private readonly Timer t = new Timer();

		public long Delay { get; private set; }

		public void SetDelay(long delay)
		{
			if (delay > 0)
			{
				this.Delay = delay;
			}
		}

		private static bool didRun = false;

		private void Tick()
		{
			DateTime bootTime = DateTime.UtcNow.AddMilliseconds(-Environment.TickCount);

			LASTINPUTINFO lii = new LASTINPUTINFO();
			lii.cbSize = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO));
			GetLastInputInfo(ref lii);

			DateTime lastInputTime = bootTime.AddMilliseconds(lii.dwTime);

			TimeSpan idleTime = DateTime.UtcNow.Subtract(lastInputTime);

			if (this.Delay > 0)
			{
				long msIdle = ConvertToMilliseconds(idleTime.Milliseconds, idleTime.Seconds, idleTime.Minutes, idleTime.Hours, idleTime.Days);

				if (msIdle == this.Delay)
				{
					didRun = true;
					this.InactivityTimeReached?.Invoke();
				}
				if (msIdle < this.Delay && didRun)
				{
					didRun = false;
					this.InputReceived?.Invoke();
				}
			}
		}
	}
}