using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace day4_task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=cmdlhrdb01;Database=5084-db;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //task9-1
                using (SqlCommand command = new SqlCommand("Students_who_are_not_Enrolled_in_Corses", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Student_ID: {reader["Student_ID"]}, First_NAME: {reader["First_NAME"]}, Last_NAME: {reader["Last_NAME"]}");
                    }
                    connection.Close();
                    Console.WriteLine(" ");
                }

                //task9-2
                using (SqlCommand command = new SqlCommand("Most_Popular_Course", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Course_ID: {reader["Course_ID"]}, REPEAT_TIME: {reader["REPEAT_TIME"]}");
                    }
                    connection.Close();
                    Console.WriteLine(" ");
                }

                //task9-3
                using (SqlCommand command = new SqlCommand("Students_Age_Above_the_AVG_Age", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Student_ID: {reader["Student_ID"]}, First_NAME: {reader["First_NAME"]}, Last_NAME: {reader["Last_NAME"]}, Age: {reader["Age"]}");
                    }
                    connection.Close();
                    Console.WriteLine(" ");
                }

                //task9-4
                using (SqlCommand command = new SqlCommand("total_number_of_students_and_average_age_for_each_course", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Course_ID: {reader["Course_ID"]}, total_Number_OF_studnets: {reader["total_Number_OF_studnets"]}, Avg_Students_Age: {reader["Avg_Students_Age"]}");
                    }
                    connection.Close();
                    Console.WriteLine(" ");
                }

                //task9-5
                using (SqlCommand command = new SqlCommand("courses_that_have_no_students_enrolled_in_them", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Course_Name: {reader["Course_Name"]}");
                    }
                    connection.Close();
                    Console.WriteLine(" ");
                }
                //task9-6
                using (SqlCommand command = new SqlCommand("students_who_share_courses_with_a_specifi_student", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@First_NAME", "SAMEER");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Student_ID: {reader["Student_ID"]}, First_NAME: {reader["First_NAME"]}, Last_NAME: {reader["Last_NAME"]}, Age: {reader["Age"]}");
                    }
                    connection.Close();
                    Console.WriteLine();
                }

                //task9-7
                using (SqlCommand command = new SqlCommand("list_the_youngest_and_oldest_student_in_each_course", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Course_Name: {reader["Course_Name"]}, Yougest_Student: {reader["Yougest_Student"]}, Eldest_Student: {reader["Eldest_Student"]}");
                    }
                    connection.Close();
                    Console.ReadKey();
                }
            }
        }
    }
}
