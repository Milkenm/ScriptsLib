﻿#region Usings
using ScriptsLib.Network;

using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendSms()
		{
			Mobile.SendSmsViaEmail(_MainForm.textBox_network_mobile_sendSms_senderEmail.Text, _MainForm.textBox_network_mobile_sendSms_senderEmailPassword.Text, _MainForm.textBox_network_mobile_sendSms_receiverPhone.Text, _MainForm.textBox_network_mobile_sendSms_subject.Text, _MainForm.textBox_network_mobile_sendSms_message.Text, _MainForm.textBox_network_mobile_sendSms_smsCarrier.Text, _MainForm.textBox_network_mobile_sendSms_smtpHost.Text, (int)_MainForm.numeric_network_mobile_sendSms_smtpPort.Value);
		}
	}
}