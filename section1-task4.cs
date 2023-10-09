using System;


namespace Section1_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number for which you'd like to find the square. ");
            double Num = Double.Parse(Console.ReadLine()); // Converting input into Double and store it into num
            double square = Num * Num; // Square of the input Number
            Console.WriteLine(square);
        }
    }
}
