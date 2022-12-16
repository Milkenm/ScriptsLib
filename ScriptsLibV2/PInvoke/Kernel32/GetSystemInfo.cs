using System;
using System.Runtime.InteropServices;

namespace ScriptsLibV2.PInvoke
{
	public static partial class Kernel32
	{
		public static SystemInfo GetSystemInfo()
		{
			SYSTEM_INFO si = new SYSTEM_INFO();
			GetSystemInfo(ref si);
			return new SystemInfo(si);
		}

		public struct SystemInfo
		{
			public SystemInfo(SYSTEM_INFO si)
			{
				this.ProcessorArchitecture = si.wProcessorArchitecture;
				this.Reserved = si.wReserved;
				this.PageSize = si.dwPageSize;
				this.MinimumApplicationAddress = si.lpMinimumApplicationAddress;
				this.MaximumApplicationAddress = si.lpMaximumApplicationAddress;
				this.ActiveProcessorMask = si.dwActiveProcessorMask;
				this.NumberOfProcessors = si.dwNumberOfProcessors;
				this.ProcessorType = si.dwProcessorType;
				this.AllocationGranularity = si.dwAllocationGranularity;
				this.ProcessorLevel = si.wProcessorLevel;
				this.ProcessorRevision = si.wProcessorRevision;
			}

			public ushort ProcessorArchitecture;
			public ushort Reserved;
			public uint PageSize;
			public IntPtr MinimumApplicationAddress;
			public IntPtr MaximumApplicationAddress;
			public IntPtr ActiveProcessorMask;
			public uint NumberOfProcessors;
			public uint ProcessorType;
			public uint AllocationGranularity;
			public ushort ProcessorLevel;
			public ushort ProcessorRevision;
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern void GetSystemInfo(ref SYSTEM_INFO Info);

		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_INFO
		{
			public ushort wProcessorArchitecture;
			public ushort wReserved;
			public uint dwPageSize;
			public IntPtr lpMinimumApplicationAddress;
			public IntPtr lpMaximumApplicationAddress;
			public IntPtr dwActiveProcessorMask;
			public uint dwNumberOfProcessors;
			public uint dwProcessorType;
			public uint dwAllocationGranularity;
			public ushort wProcessorLevel;
			public ushort wProcessorRevision;
		}
	}
}
