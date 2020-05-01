using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TGL_Project
{
    public class EmailService
    {

        public void SendEmailDefault(string email, string subject, string textMessage)
        {
            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress("user@gmail.com", "Мой Email");
            message.To.Add(email);
            message.Subject = subject;
            message.Body = textMessage;

            // message.Attachments.Add(new Attachment("..путь к файлу...."));
            using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com"))
            {
                client.Credentials = new NetworkCredential("user@gmail.com", "123456789");
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);

            }


        }
    }
}
