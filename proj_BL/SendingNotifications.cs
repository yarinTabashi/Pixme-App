using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace BLFinalPro
{
    public class SendingNotifications
    {
        public bool SendingMail(string body, string to, string subj)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("my.email@gmail.com");
                mail.To.Add(to.ToString());
                mail.Subject = subj.ToString();
                mail.Body = body.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("my.email@gmail.com", "mypassword");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
