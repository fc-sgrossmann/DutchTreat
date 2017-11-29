using System;
using System.Net.Mail;
using System.Net;
using DutchTreat.ViewModels;
namespace DutchTreat.Classes
{
    public class email
    {
        public email(KontaktViewModel contact)
        {
            if(String.IsNullOrEmpty(contact.nachricht) || String.IsNullOrEmpty(contact.betreff)) {
                return;
            }
            try {
                SmtpClient client = new SmtpClient("smtp.strato.de");
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("info@fahrende-saenger.de", "info4711");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("info@fahrende-saenger.de");
                mailMessage.To.Add("stefan.grossmann68@gmail.com");
                mailMessage.Body = contact.nachricht;
                mailMessage.Subject = contact.betreff + " - " + contact.name;
                client.Send(mailMessage);
            }
            catch(Exception ex) {
                throw new ApplicationException(ex.ToString());
            }
        }
    }
}
