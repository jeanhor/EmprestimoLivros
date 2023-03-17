using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Infra.Services
{
    public class MailService : IMailService
    {
        private string smtpAdress => "smtp.gmail.com";
        private int portNumber => 587;
        private string emailFromAddress => "jean.horacio35@gmail.com";
        private string password => "jxxuatypibbuuqye";
        public void AddEmailsToMailMessage(MailMessage mailMessage, string[] emails)
        {
            foreach(var email in emails)
            {
                mailMessage.To.Add(email);
            }
        }
        public void SendMail(string[] emails, string subject, string body, bool isHtm = false )
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(emailFromAddress);
                AddEmailsToMailMessage(mailMessage, emails);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = isHtm;
                using (SmtpClient smtp = new SmtpClient(smtpAdress, portNumber)) 
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.Send(mailMessage);
                }
            }
        }

        
    }
}
