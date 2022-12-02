using System;
using System.Threading;
using System.Threading.Tasks;

namespace ScriptsLibR
{
	public class Timer
	{
		private long _Interval = 1;
		public long Interval
		{
			get
			{
				return _Interval;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException($"Interval cannot be less than 1 (was {value}).");
				}
				if (_Interval != value)
				{
					_Interval = value;
					CurrentMilliTick = 0;
				}
			}
		}

		private bool IsRunning = false;

		private Task TimerTask;
		private long CurrentMilliTick = 0; // Milliseconds
		private long CurrentTick = 0; // Milliseconds

		public Timer(long interval)
		{
			this.Interval = interval;
			SetupTask();
		}

		private void SetupTask()
		{
			// Stop existing timer task \\
			TimerTask?.Dispose();
			CurrentMilliTick = 0;
			// Setup a new timer \\
			TimerTask = new Task(new Action(() =>
			{
				while (true)
				{
					if (!IsRunning)
					{
						continue;
					}
					Thread.Sleep(1);
					CurrentMilliTick++;
					if (CurrentMilliTick >= this.Interval)
					{
						CurrentMilliTick = 0;
						CurrentTick++;
						OnTick?.Invoke(CurrentTick);
					}
				}
			}));
		}

		public delegate void TickEvent(long currentTick);
		public event TickEvent OnTick;

		public void Start()
		{
			IsRunning = true;
		}

		public void Stop()
		{
			IsRunning = false;
		}
	}
}
