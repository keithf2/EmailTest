using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EmailTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage("foglek@gmail.com", "keithf@qvinci.com");
            mail.Subject = "Test Email";
            mail.Body = "Test Email Body";
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            NetworkCredential cred = new NetworkCredential("foglek@gmail.com", "xxxxxxxx");
            client.UseDefaultCredentials = false;
            client.Credentials = cred;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}
