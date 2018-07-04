using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GoDaddyEmail_Core
{
    internal class EmailTools : IEmailTools
    {
        public bool SendEmail(string to, string body)
        {
            try
            {
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("charlespkolstad@202mobileservice.com");
                    message.To.Add(new MailAddress(to));
                    message.Subject = "New email message";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.Priority = MailPriority.High;

                    using (SmtpClient client = new SmtpClient("relay-hosting.secureserver.net", 587))
                    {
                        client.EnableSsl = false;
                        client.Credentials = new NetworkCredential("charlespkolstad@202mobileservice.com", "Email123Pass!");
                        client.Port = 25;
                        client.Send(message);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;                
            }
        }
    }

    internal class FakeEmailTools : IEmailTools
    {
        public bool SendEmail(string to, string body)
        {
            return true;
        }
    }

    internal interface IEmailTools
    {
        bool SendEmail(string to, string body);
    }
}
