using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    public class EmailSender
    {
        public static bool SendEmailNotification(string borrowerEmail, string adminEmail)
        {
            //LOGIC SEND EMAIL

            //try
            //{
            //    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            //    client.Host = "smtp.gmail.com";
            //    client.UseDefaultCredentials = false;
            //    client.EnableSsl = false;
            //    client.Credentials = new System.Net.NetworkCredential("IAP", "password of IAP");
            //    client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage("IAP@gmail.com", recieve email);
            //    message.Subject = "<By Default: IAP Choices Notification>";
            //    message.Body = "Hi"+"<Name>"+ ", the item you borrowed must be returned!";

            //    message.BodyEncoding = System.Text.Encoding.UTF8;
            //    message.IsBodyHtml = true;


            //    try
            //    {
            //        client.Send(message);
            //        return true;
            //    }
            //    catch
            //    {

            //        return false;
            //    }
            //}
            //catch
            //{

            //    return false;
            //}

           return true;
        }
    }
}
