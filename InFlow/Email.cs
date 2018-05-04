using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading;

namespace InFlow
{
    public class Email
    {
        Random rnd;
        SmtpClient client;

        public Email()
        {
            rnd = new Random();
            client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("theprimebaby2018@gmail.com", "theprimebaby1234");
            // do not do anything in constructor
        }

        public void EmailClient(string ClientEmail, string Subject, string EmailBody)
        {

            try
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    MailMessage mm = new MailMessage("donotreply@theprimebaby.com", ClientEmail, Subject, EmailBody);
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(mm);
                }).Start();
                
            }
            catch (Exception ex)
            {
                Logging.NewLog("EmailClient", "Error sending email\n" + ex);
                return;
            }
        }


        public int SendOTP(string EmailID)
        {
            int otp = rnd.Next(10000, 99999);
            string subject = "Your One Time Password";
            string body = "Welcome to The Prime Baby.\nYour One Time Password is: " + otp;


            EmailClient(EmailID, subject, body);
            return otp;

        }

        


    }
}
