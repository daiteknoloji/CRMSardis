using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace CRMSardis.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string toEmail, string subject, string body)
        {
            // SMTP ayarlarını appsettings.json'dan oku
            var smtpSettings = _configuration.GetSection("SmtpSettings");

            var smtpClient = new SmtpClient(smtpSettings["Server"])
            {
                Port = int.Parse(smtpSettings["Port"]),
                Credentials = new NetworkCredential(smtpSettings["SenderEmail"], smtpSettings["Password"]),
                EnableSsl = bool.Parse(smtpSettings["UseSSL"])
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(smtpSettings["SenderEmail"], smtpSettings["SenderName"]),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            // E-posta gönder
            smtpClient.Send(mailMessage);
        }
    }
}
