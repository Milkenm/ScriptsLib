using System.Net;
using System.Net.Mail;

namespace ScriptsLib.Network
{
	public static partial class Mobile
	{
		/// <summary>[WIP] It doesn't work lmao. (report this if u see)</summary>
		/// <param name="_SenderEmail">The e-mail from where the SMS will be sent.</param>
		/// <param name="_SenderEmailPassword">The password required to access the sender's e-mail.</param>
		/// <param name="_ReceiverPhoneNumber">The phone number to where the SMS will be sent.</param>
		/// <param name="_Subject">The title of the SMS.</param>
		/// <param name="_Message">The message (or the SMS).</param>
		/// <param name="_SmsCarrier">Idk (report if u see this).</param>
		/// <param name="_SmtpHost">Idk (report if u see this).</param>
		/// <param name="_SmtpPort">Idk (report if u see this).</param>
		public static void SendSmsViaEmail(string _SenderEmail, string _SenderEmailPassword, string _ReceiverPhoneNumber, string _Subject, string _Message, string _SmsCarrier = "txt.att.net", string _SmtpHost = "smtp.gmail.com", int _SmtpPort = 587)
		{
			// Gateway.
			string _Recipent = string.Concat(new object[] { _ReceiverPhoneNumber, '@', _SmsCarrier });

			// Form the message.
			MailMessage _Sms = new MailMessage(_SenderEmail, _Recipent, _Subject, _Message);

			// Create the client...
			SmtpClient _SmsClient = new SmtpClient(_SmtpHost, _SmtpPort);
			_SmsClient.UseDefaultCredentials = false;
			_SmsClient.EnableSsl = true;
			_SmsClient.Credentials = new NetworkCredential(_SenderEmail, _SenderEmailPassword);
			// ...and then send it.
			_SmsClient.Send(_Sms);
		}
	}
}
