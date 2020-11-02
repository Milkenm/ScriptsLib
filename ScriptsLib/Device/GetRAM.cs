using System;
using System.Management;

namespace ScriptsLib
{
	public static partial class Device
	{
		/// <summary>Gets Max/Free/Used RAM in GB.</summary>
		/// <param name="type">Max/Free/Used</param>
		public static double GetRAM(RAMType type)
		{
			ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
			ManagementObjectSearcher search = new ManagementObjectSearcher(query);
			ManagementObjectCollection results = search.Get();

			double ram = 0;

			if (type == RAMType.Max)
			{
				foreach (ManagementBaseObject result in results)
				{
					ram = Math.Round(Convert.ToDouble(result["TotalVisibleMemorySize"]) / (1024 * 1024), 2);
				}
			}
			else if (type == RAMType.Free)
			{
				foreach (ManagementBaseObject result in results)
				{
					ram = Math.Round(Convert.ToDouble(result["FreePhysicalMemory"]) / (1024 * 1024), 2);
				}
			}
			else if (type == RAMType.Used)
			{
				foreach (ManagementBaseObject result in results)
				{
					ram = Math.Round(Convert.ToDouble(result["TotalVisibleMemorySize"]) / (1024 * 1024), 2);
				}
				foreach (ManagementBaseObject result in results)
				{
					ram -= Math.Round(Convert.ToDouble(result["FreePhysicalMemory"]) / (1024 * 1024), 2);
				}
			}

			return ram;
		}

		public enum RAMType
		{
			Max,
			Free,
			Used,
		}
	}
}