using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SendEmail
    {

        public bool send()
        {
            string to = "nguoinhan@email.com";
            string from = "nguoigui@email.com";
            string password = "password";
            string subject = "Chủ đề";
            string body = "Nội dung email";

            MailMessage mail = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(from, password);
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
                return true;
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
