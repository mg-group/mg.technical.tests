using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public static class EmailSender
    {
        private static readonly string EmailRelayHost = ConfigurationManager.AppSettings.Get("EmailRelayHost");
        private static readonly int EmailPort = Int32.Parse(ConfigurationManager.AppSettings.Get("EmailPort"));
        private static readonly string EmailRelayUser = ConfigurationManager.AppSettings.Get("EmailRelayUser");
        private static readonly string EmailRelayPwd = ConfigurationManager.AppSettings.Get("EmailRelayPwd");

        public static void Send(string from, string to, string subject, string message)
        {
            SmtpClient client = new SmtpClient();
            client.Host = EmailRelayHost;
            client.Port = EmailPort;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(EmailRelayUser, EmailRelayPwd);

            MailMessage mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = message;

            client.Send(mail);
        }
    }
}
