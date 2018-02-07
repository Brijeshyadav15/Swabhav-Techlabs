using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command1 = conn.CreateCommand();
            SqlCommand command2 = conn.CreateCommand();



            SqlTransaction transaction = conn.BeginTransaction("Transaction Example");

            SqlCommand selectMerchant = new SqlCommand("Select * from  Merchant", conn);
            SqlCommand selectCustomer = new SqlCommand("Select * from  Customer", conn);

            SqlDataReader selectreader;

            command1.CommandText = "update Merchant Set balance = balance + 250";
            command1.CommandText = "update Customer Set balance = balance - 0";

            command1.Connection = conn;
            command1.Transaction = transaction;

            command2.Connection = conn;
            command2.Transaction = transaction;

            try
            {

                command1.ExecuteNonQuery();

                selectreader = selectMerchant.ExecuteReader();
                while (selectreader.Read())
                {
                    Console.WriteLine(selectreader[0]);
                }

                command2.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);

                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);

                }
            }
        }
    }
}
