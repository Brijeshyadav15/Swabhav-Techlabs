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
            
            SqlCommand command = conn.CreateCommand();
            SqlTransaction transaction = conn.BeginTransaction("Transaction Example");

            command.Connection = conn;
            command.Transaction = transaction;

            try
            {
                command.CommandText = "update Merchant Set balance = balance + 250";
                command.ExecuteNonQuery();
                command.CommandText = "update Customer Set balance = balance - '0F'";
                command.ExecuteNonQuery();

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
                catch(Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);

                }
            }
        }
    }
}
