using System;
using DutchTreat.ViewModels;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        public EmailService(ILogger<EmailService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(KontaktViewModel contact)
        {
            if (String.IsNullOrEmpty(contact.nachricht) || String.IsNullOrEmpty(contact.betreff))
            {
                return;
            }
            try
            {
                String an = "stefan.grossmann68@gmail.com";
                //SmtpClient client = new SmtpClient("smtp.strato.de");
                //client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("info@fahrende-saenger.de", "info4711");

                //MailMessage mailMessage = new MailMessage();
                //mailMessage.From = new MailAddress("info@fahrende-saenger.de");
                //mailMessage.To.Add(an);
                //mailMessage.Body = contact.nachricht;
                //mailMessage.Subject = contact.betreff + " - " + contact.name;
                //client.Send(mailMessage);
                _logger.LogInformation($"An: {an} Betreff: {contact.betreff} Nachricht: {contact.nachricht}");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }
    }
}