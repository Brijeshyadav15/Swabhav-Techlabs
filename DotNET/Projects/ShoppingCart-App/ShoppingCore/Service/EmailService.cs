using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Service
{
    class EmailService
    {

        public void SendRegisterMail(string to, string name, string password)
        {

            MailAddress receiepent = new MailAddress(to);
            MailAddress sender = new MailAddress("brijeshyyadav152@gmail.com");
            MailMessage mail = new MailMessage(sender, receiepent);
            mail.Subject = "Bookmarks User Registration";
            mail.Body = "Hi " + name + "! <br> Thanks so much for signing up for the Shopaholic !! Your Password is "+ password+"!! <br> You’re joining an amazing community of shoppers who love shopping online.";
            mail.Body = "Oh, by the way, let’s introduce ourselves before we get going.Shopaholic is a online shopping app that helps you buy the  important and trendiest things of the Fashion World";
            mail.Body += "We’d love to chat. Just hit reply to this email or any of our newsletters to get in touch with feedback, questions, or ideas for us!<br>";
            mail.Body += "Have an awesome day! Lewis, Shopaholic Founder";
 
             mail.Body = "Hi " + name + ",Thank you registering with Bookmarks App. Your Auto generated password is : " + password + ". You can change your password after First Login";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("brijeshyyadav152@gmail.com", "qwerty@123");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
                Console.WriteLine("Mail Sent");
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }

        }
    }
}
