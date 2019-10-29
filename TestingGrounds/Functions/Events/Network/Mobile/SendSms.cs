#region Usings
using ScriptsLib.Network;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendSms()
		{
			Mobile.SendSmsViaEmail(MainForm.textBox_network_mobile_sendSms_senderEmail.Text, MainForm.textBox_network_mobile_sendSms_senderEmailPassword.Text, MainForm.textBox_network_mobile_sendSms_receiverPhone.Text, MainForm.textBox_network_mobile_sendSms_subject.Text, MainForm.textBox_network_mobile_sendSms_message.Text, MainForm.textBox_network_mobile_sendSms_smsCarrier.Text, MainForm.textBox_network_mobile_sendSms_smtpHost.Text, (int)MainForm.numeric_network_mobile_sendSms_smtpPort.Value);
		}
	}
}