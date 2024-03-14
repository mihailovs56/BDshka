using System.Data.SqlClient;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MIHAILOV;Initial Catalog=RegAndLog;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Пользователь";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    string lastname = (string)reader["lastname"];

                    Console.WriteLine("ID: " + id);
                    Console.WriteLine("Имя: " + name);
                    Console.WriteLine("Фамилия: " + lastname);
                    Console.WriteLine("------------------------");
                }
                reader.Close();
            }
            Console.ReadKey();
        }
    }
}
