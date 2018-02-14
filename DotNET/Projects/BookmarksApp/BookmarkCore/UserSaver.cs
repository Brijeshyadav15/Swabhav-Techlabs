using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace BookmarkCore
{

    public class UserSaver
    {
        public void AddUser(string name, string email)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            var password = GeneratePassword(8);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand insertCommand = new SqlCommand("Insert into BookMarkUsers Values('" + name + "','" + email + "','" + password + "')", conn);

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
            SendRegisterMail(email, name, password);

        }


        private static Random random = new Random();
        public string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }

        public void SendRegisterMail(string to, string name, string password)
        {

            MailAddress receiepent = new MailAddress(to);
            MailAddress sender = new MailAddress("brijeshyyadav152@gmail.com");
            MailMessage mail = new MailMessage(sender, receiepent);
            mail.Subject = "Bookmarks User Registration";
            mail.Body = "Hi " + name + ",Thank you registering with Bookmarks App. Your Auto generated password is : " + password + ". You can change your password after First Login";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("brijeshyyadav152@gmail.com", "Brijesh@123");
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
