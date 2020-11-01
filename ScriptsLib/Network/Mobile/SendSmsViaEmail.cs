using System.Net;
using System.Net.Mail;

namespace ScriptsLib.Network
{
	public static partial class Mobile
	{
		/// <param name="senderEmail">The e-mail from where the SMS will be sent.</param>
		/// <param name="senderEmailPassword">The password required to access the sender's e-mail.</param>
		/// <param name="receiverPhoneNumber">The phone number to where the SMS will be sent.</param>
		/// <param name="subject">The title of the SMS.</param>
		/// <param name="message">The message (or the SMS).</param>
		public static void SendSmsViaEmail(string senderEmail, string senderEmailPassword, string receiverPhoneNumber, string subject, string message, string smsCarrier = "txt.att.net", string smtpHost = "smtp.gmail.com", int smtpPort = 587)
		{
			// Gateway
			string recipent = string.Concat(new object[] { receiverPhoneNumber, '@', smsCarrier });

			// Form the message
			MailMessage sms = new MailMessage(senderEmail, recipent, subject, message);

			// Create the client
			SmtpClient smsClient = new SmtpClient(smtpHost, smtpPort)
			{
				UseDefaultCredentials = false,
				EnableSsl = true,
				Credentials = new NetworkCredential(senderEmail, senderEmailPassword),
			};

			// Send the SMS
			smsClient.Send(sms);
		}
	}
}
