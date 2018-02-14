using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Mail_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("brijeshyyadav152@gmail.com");
            //mail.To.Add("brijeshyadav152@gmail.com");
            //mail.Subject = "Bookmarks User Registration";
            //mail.Body = "TEST MAIL";

            //SmtpClient client = new SmtpClient();
            //client.Host = "smtp.gmail.com";
            //client.Port = 587;
            //client.Credentials = new NetworkCredential("brijeshyyadav152@gmail.com", "Brijesh@123");
            //client.EnableSsl = true;
            ////client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;

            //try
            //{
            //    client.Send(mail);
            //    Console.WriteLine("Mail Sent");
            //}
            //catch
            //{
            //    Console.WriteLine("Exception occurred");
            //}

            Console.WriteLine("Mail To");
            MailAddress to = new MailAddress("brijeshyadav152@gmail.com");

            Console.WriteLine("Mail From");
            MailAddress from = new MailAddress("brijeshyyadav152@gmail.com");

            MailMessage mail = new MailMessage(from, to);

            Console.WriteLine("Subject");
            mail.Subject = "Bookmarks User Registration";

            Console.WriteLine("Your Message");
            mail.Body = "TEST MAIL";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("brijeshyyadav152@gmail.com", "Brijesh@123");
            smtp.EnableSsl = true;
            Console.WriteLine("Sending email...");
            smtp.Send(mail);
        }
    }
}
