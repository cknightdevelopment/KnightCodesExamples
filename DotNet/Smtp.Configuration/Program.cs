using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Smtp.Configuration
{
	class Program
	{
		static void Main(string[] args)
		{
			using (SmtpClient client = new SmtpClient())
			using (MailMessage message = new MailMessage())
			{
				message.To.Add("toAddress@domain.com");
				message.IsBodyHtml = true;
				message.Subject = "Subject";
				message.Body = "Body";

				try
				{
					// send the email
					client.Send(message);
				}
				catch (SmtpException ex)
				{
					// log exception
				}
			}
		}
	}
}
