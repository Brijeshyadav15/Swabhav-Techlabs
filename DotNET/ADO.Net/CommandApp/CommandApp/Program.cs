using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            
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
        }
    }
}
