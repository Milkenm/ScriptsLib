using System;
using System.Runtime.InteropServices;

using static ScriptsLibR.PInvoke.User32;

namespace ScriptsLibR.Unsorted
{
	public class InputInactivity
	{
		/// <summary>Triggers an event after some time of user inactivity.</summary>
		/// <param name="delay">The time in milliseconds to trigger the inactivity event.</param>
		public InputInactivity(long delay = 0)
		{
			this.SetDelay(delay);

			t.OnTick += (tick) => this.Tick();
			t.Start();
		}

		public delegate void InputInactivityEvent();
		public event InputInactivityEvent InputReceived;
		public event InputInactivityEvent InactivityTimeReached;

		private readonly Timer t = new Timer(1);

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
			if (this.Delay > 0)
			{
				DateTime bootTime = DateTime.UtcNow.AddMilliseconds(-Environment.TickCount);

				LASTINPUTINFO lii = new LASTINPUTINFO();
				lii.cbSize = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO));
				GetLastInputInfo(ref lii);

				DateTime lastInputTime = bootTime.AddMilliseconds(lii.dwTime);
				TimeSpan idleTime = DateTime.UtcNow.Subtract(lastInputTime);

				long msIdle = idleTime.Milliseconds + Utils.Utils.ConvertToMilliseconds(idleTime.Seconds, idleTime.Minutes, idleTime.Hours, idleTime.Days);
				if (msIdle >= this.Delay && didRun == false)
				{
					didRun = true;
					this.InactivityTimeReached?.Invoke();
				}
				else if (msIdle <= this.Delay && didRun)
				{
					didRun = false;
					this.InputReceived?.Invoke();
				}
			}
		}
	}
}