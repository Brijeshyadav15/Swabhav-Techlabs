using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SQLInjectionAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            Console.WriteLine("Enter EMP NO to search:");
            string empno = Console.ReadLine();
            SqlCommand fetchCommand = new SqlCommand("Select * from EMP WHERE EMPNO = " + empno + "", conn);
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
