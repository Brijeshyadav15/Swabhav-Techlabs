using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Globalization;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand fetchCommand = new SqlCommand("Select * from EMP", conn);
            conn.Open();

            SqlDataReader reader = fetchCommand.ExecuteReader();

            Console.WriteLine("EMPNO\tENAME\tJOB\tMANAGER\tHIREDATE\tSAL\tCOMM\tDEPTNO");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime dt1 = DateTime.Parse(reader[4].ToString());
                    var date = dt1.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat);
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2].ToString().Substring(0, 5) + "\t" + reader[3] + "\t" + date + "\t" + reader[5].ToString().Split('.')[0] + "\t" + reader[6].ToString().Split('.')[0] + "\t" + reader[7]);
                }
            }
            else
            {
                Console.WriteLine("No Data found");
            }
        }
    }
}
