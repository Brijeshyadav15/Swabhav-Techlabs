using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BasicConnectApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //String connectionString = @"server=BRIJESH\SQLEXPRESS;database=Techlabs;Integrated Security=True";
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand insertCommand = new SqlCommand("Insert into organizers(organizer_id,organizer_name,organizer_contact)Values(1,'Brijesh','9876543210')", conn);
            insertCommand.ExecuteNonQuery();
            SqlCommand fetchCommand = new SqlCommand("Select * from organizers", conn);


            SqlDataReader reader = fetchCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.ToString());
                }

            }
            else
            {
                Console.WriteLine("No Data found");
            }
            try
            {
                Console.WriteLine(conn.State);
                Console.WriteLine(conn.Database);
                Console.WriteLine(conn.DataSource);
                Console.WriteLine(conn.Container);
                Console.WriteLine(conn.ConnectionString);
                Console.WriteLine(conn.StatisticsEnabled);
                Console.WriteLine(conn.ServerVersion);
                Console.WriteLine(conn.PacketSize);
                Console.WriteLine(conn.WorkstationId);
                Console.WriteLine(conn.ConnectionTimeout);
                Console.WriteLine(conn.GetType());
                Console.WriteLine(conn.State.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Console.WriteLine(conn.State);
            }
            Console.ReadKey();

        }
    }
}
