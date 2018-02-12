using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace BookmarkCore
{

    class UserSaver
    {
        public void AddUser(int id, string name, string email)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            var password = GeneratePassword(8);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand insertCommand = new SqlCommand("Insert into BookMarkUsers Values(" + id + ", '" + name + "','" + email + "','" + password + "')", conn);

            //insertCommand.Parameters.Add("@id", SqlDbType.Int);
            //insertCommand.Parameters["@id"].Value = id;

            //insertCommand.Parameters.Add("@name", SqlDbType.VarChar);
            //insertCommand.Parameters["@name"].Value = name;

            //insertCommand.Parameters.Add("@email", SqlDbType.VarChar);
            //insertCommand.Parameters["@email"].Value = email;

            //insertCommand.Parameters.Add("@password", SqlDbType.VarChar);
            //insertCommand.Parameters["@password"].Value = password;


            conn.Open();

            insertCommand.ExecuteNonQuery();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("brijeshyyadav152@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Bookmarks User Registration";
            mail.Body = "Hello " + name + ", Thank you for Registrating with us. Your Password is " + password + " ";

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("brijeshyyadav152@gmail.com", "Brijesh@123");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Send(mail);
            try
            {
                
                Console.WriteLine("Mail Sent");
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }


            //var fromAddress = new MailAddress("brijeshyyadav152@gmail.com", "BookMarks App");
            //var toAddress = new MailAddress(email, name);
            //const string fromPassword = "Brijesh@123";
            //const string subject = "Bookmarks User Registration";            
            //const string body = "Hello   + name +  , Thank you for Registrating with us. Your Password is   + password + ";

            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = false,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};

            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    smtp.Send(message);
            //}
        }


        private static Random random = new Random();
        public static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }

    }
}
