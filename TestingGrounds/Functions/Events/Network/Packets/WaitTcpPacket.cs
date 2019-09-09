﻿#region Usings
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.nNetwork;

using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_WaitTcpPacket()
		{
			_MainForm.button_network_packets_waitTcpPacket_wait.Enabled = false;
			new Task(new Action(() =>
			{
				while (true)
				{
					MessageBox.Show("Received: \n\n\n" + Packets.WaitTcpPacket(IPAddress.Parse("127.0.0.1"), 69), "Wait TCP Packet");
				}
			})).Start();
		}
	}
}