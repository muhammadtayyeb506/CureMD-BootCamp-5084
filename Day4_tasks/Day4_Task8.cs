using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=cmdlhrdb01;Database=5084-db;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                     // 1. Execute Stored Procedure to List All Students
                    using (SqlCommand command = new SqlCommand("ListAllStudents", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine($"Student_ID: {reader["Student_ID"]}, First_NAME: {reader["First_NAME"]}, Last_NAME: {reader["Last_NAME"]}, Age: {reader["Age"]}, Course_ID: {reader["Course_ID"]}");
                            }
                        connection.Close();
                    }


                    // 2. Execute Stored Procedure to Add Student
                    using (SqlCommand command = new SqlCommand("AddStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@First_NAME", "Tayyeb");
                        command.Parameters.AddWithValue("@Last_NAME", "Tahir");
                        command.Parameters.AddWithValue("@Age", 55);
                        command.Parameters.AddWithValue("@Course_ID", 1);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // 3. Execute Stored Procedure to Update Student Age
                    using (SqlCommand command = new SqlCommand("UpdateStudentAge", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Student_ID", 1);
                        command.Parameters.AddWithValue("@NewAge", 50);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // 4. Execute Stored Procedure to Delete Student
                    using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Student_ID", 1);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                Console.WriteLine(" ");

                    // 1. Execute Stored Procedure to List All Students
                    using (SqlCommand command = new SqlCommand("ListAllStudents", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"Student_ID: {reader["Student_ID"]}, First_NAME: {reader["First_NAME"]}, Last_NAME: {reader["Last_NAME"]}, Age: {reader["Age"]}, Course_ID: {reader["Course_ID"]}");
                        }
                        connection.Close();
                        Console.ReadKey();
                    }
            }
        }
    }
}


    

