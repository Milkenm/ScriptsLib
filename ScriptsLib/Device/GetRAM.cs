#region Usings
using System;
using System.Management;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Device
	{
		/// <summary>Gets Max/Free/Used RAM in GB.</summary>
		/// <param name="_Type">Max/Free/Used</param>
		public static double GetRAM(RAMType _Type)
		{
			ObjectQuery _Query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
			ManagementObjectSearcher _Search = new ManagementObjectSearcher(_Query);
			ManagementObjectCollection _Results = _Search.Get();

			double _Ram = 0;

			if (_Type == RAMType.Max)
			{
				foreach (ManagementBaseObject result in _Results)
				{
					_Ram = Math.Round(Convert.ToDouble(result["TotalVisibleMemorySize"]) / (1024 * 1024), 2);
				}
			}
			else if (_Type == RAMType.Free)
			{
				foreach (ManagementBaseObject result in _Results)
				{
					_Ram = Math.Round(Convert.ToDouble(result["FreePhysicalMemory"]) / (1024 * 1024), 2);
				}
			}
			else if (_Type == RAMType.Used)
			{
				foreach (ManagementBaseObject result in _Results)
				{
					_Ram = Math.Round(Convert.ToDouble(result["TotalVisibleMemorySize"]) / (1024 * 1024), 2);
				}
				foreach (ManagementBaseObject result in _Results)
				{
					_Ram = _Ram - Math.Round(Convert.ToDouble(result["FreePhysicalMemory"]) / (1024 * 1024), 2);
				}
			}

			return _Ram;
		}



		public enum RAMType
		{
			Max,
			Free,
			Used,
		}
	}
}
