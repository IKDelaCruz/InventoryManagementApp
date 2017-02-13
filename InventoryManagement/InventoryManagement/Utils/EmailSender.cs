using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace InventoryManagement.Utils
{
    public class EmailSender
    {
        public static void SendMail(int user)
        {
            //SEND EMAIL NOTIFICATION TO USER - richmond.mendoza@jakagroup.com
            //AND ADMIN - mis@jakagroup.com

            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //message.To.Add("itsjpua@gmail.com");
            //message.Subject = "This is the Subject line";
            message.From = new System.Net.Mail.MailAddress("pua.jeanne@gmail.com");
            //message.Body = "This is the message body";
            //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 578);

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("pua.jeanne@gmail.com", "popoislove"),
                EnableSsl = true
            };

            string msg = "The item " + "User with User ID: " + user+ " " + "borrowed is expected to be returned today. Please notify the user.";
            client.Send("pua.jeanne@gmail.com", "itsjpua@gmail.com", "Return Item", msg);

        }
    }
}
