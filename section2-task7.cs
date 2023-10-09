using System;


namespace Section2_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Name of Table");
            int tableNo = int.Parse(Console.ReadLine());// Converting input into integer and store it.
           
            for (int i = 1; i <= 12; i++) // Simple Conditions Given For for Loop
            {
                int table = tableNo * i;
                Console.WriteLine(tableNo + " X " + i + " = " + table); // Concatinate Strings And Number to Show the Table in elegant way
            }
        }
    }
}
